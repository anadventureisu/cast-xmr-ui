using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cast_xmr_ui
{
    public class AppStateMachine
    {
        public IState CurrentState { get; private set; }
        public Form1 Form { get; set; }

        public AppStateMachine(Form1 form)
        {
            this.Form = form;
            CurrentState = new IdleState();
            Form.SetStateLabel(CurrentState.ToString());
            CurrentState.EnterState(this);
        }

        public void HandleEvent(AppEvent evt)
        {
            IState newState = CurrentState.Transition(evt, this);
            if (newState != null)
            {
                CurrentState = newState;
                Form.SetStateLabel(CurrentState.ToString());
                CurrentState.EnterState(this);
            }
        }
    }

    public interface IState
    {
        /// <summary>
        /// Handles state change events from this state.
        /// </summary>
        /// <param name="evt">the AppEvent to trigger on</param>
        /// <param name="machine">The state machine for reference</param>
        /// <returns>The next State to transition into.  Return null to stay in this state.</returns>
        /// <exception cref="InvalidStateTransitionException">thrown when an invalid event is received for the current state.</exception>
        IState Transition(AppEvent evt, AppStateMachine machine);

        /// <summary>
        /// Invoked to execute whatever logic is required to enter a state.
        /// </summary>
        void EnterState(AppStateMachine machine);
    }

    /// <summary>
    /// Transition events defined by the state machine.
    /// </summary>
    public enum AppEvent
    {
        START_CLICKED,
        STOP_CLICKED,
        EXITED,
        FAILED,
        WS_UPDATE,
        WS_UPDATE_FAILED,
        TIMER_TICK,
        TIMEOUT,
        RATE_LOW
    }

    /// <summary>
    /// Thrown when an invalid transition is triggered.
    /// </summary>
    public class InvalidStateTransitionException : Exception
    {
        public InvalidStateTransitionException(IState state, AppEvent evt)
            : base(string.Format("State {0} cannot transition on event {1}", state.ToString(), evt.ToString()))
        {
        }
    }

    /// <summary>
    /// The IdleState is when the miner is not running and the application is idle.
    /// </summary>
    public class IdleState : IState
    {
        public IState Transition(AppEvent evt, AppStateMachine machine)
        {
            switch (evt)
            {
                case AppEvent.START_CLICKED:
                    return new LaunchingState();
                default:
                    throw new InvalidStateTransitionException(this, evt);
            }
        }

        public override string ToString()
        {
            return "Idle";
        }

        public void EnterState(AppStateMachine machine)
        {
            machine.Form.EnableStartButton();
        }
    }

    /// <summary>
    /// This state is when the miner is starting up, but the web service is not
    /// available yet.  We're looking to see that everything starts properly,
    /// otherwise we'll retry.
    /// </summary>
    public class LaunchingState : IState
    {
        public IState Transition(AppEvent evt, AppStateMachine machine)
        {
            switch (evt)
            {
                case AppEvent.STOP_CLICKED:
                    return new StoppingState();
                case AppEvent.EXITED:
                    return new LaunchingState();
                case AppEvent.TIMEOUT:
                    return new RestartState();
                case AppEvent.WS_UPDATE:
                    return new RunningState();
                case AppEvent.WS_UPDATE_FAILED:
                    // try again... WS doesn't come up right away.
                    machine.Form.BeginUpdateStatus();
                    return null;
                case AppEvent.FAILED:
                    return new IdleState();
                default:
                    throw new InvalidStateTransitionException(this, evt);
            }
        }

        public override string ToString()
        {
            return "Launching";
        }

        /// <summary>
        /// Try to launch the miner.  If it starts, then wait for WS to come up.  If it fails to come up within a few seconds,
        /// we will terminate and try again (assuming that it hung on startup-- totally possible).
        /// </summary>
        /// <param name="machine"></param>
        public void EnterState(AppStateMachine machine)
        {
            // Cancel any pending WS ops in case of failure to launch.
            machine.Form.CancelUpdateStatus();
            if (machine.Form.StartMiner())
            {
                machine.Form.DisableStartButton();
                machine.Form.StartTimeoutTimer();
                machine.Form.BeginUpdateStatus();
            }
        }
    }

    /// <summary>
    /// This state is when the miner is running, but we're waiting to do another
    /// status update.
    /// </summary>
    public class RunningState : IState
    {
        public IState Transition(AppEvent evt, AppStateMachine machine)
        {
            switch (evt)
            {
                case AppEvent.STOP_CLICKED:
                    return new StoppingState();
                case AppEvent.EXITED:
                    return new RestartState();
                case AppEvent.TIMER_TICK:
                    return new UpdatingState();
                default:
                    throw new InvalidStateTransitionException(this, evt);
            }
        }

        public override string ToString()
        {
            return "Running";
        }

        /// <summary>
        /// We've now started.  Cancel the startup timeout timer and start the update timer.
        /// </summary>
        /// <param name="machine"></param>
        public void EnterState(AppStateMachine machine)
        {
            machine.Form.StopTimeoutTimer();
            machine.Form.StartUpdateTimer();
        }
    }

    /// <summary>
    /// The UpdatingState is when we've made a call to the web service for a 
    /// status update and are awaiting a response.
    /// </summary>
    public class UpdatingState : IState
    {
        public IState Transition(AppEvent evt, AppStateMachine machine)
        {
            switch (evt)
            {
                case AppEvent.STOP_CLICKED:
                    return new StoppingState();
                case AppEvent.EXITED:
                    return new RestartState();
                case AppEvent.WS_UPDATE:
                    return new RunningState();
                case AppEvent.RATE_LOW:
                    return new RestartState();
                case AppEvent.WS_UPDATE_FAILED:
                    // TODO: We could probably count consecutive failures and exit
                    // but for now, just ignore.. the rate will start to drop.
                    return new RunningState();
                default:
                    throw new InvalidStateTransitionException(this, evt);
            }
        }

        public override string ToString()
        {
            return "Updating";
        }

        public void EnterState(AppStateMachine machine)
        {
            // Stop the timer so it doesn't fire again right away and start the update
            machine.Form.StopUpdateTimer();
            machine.Form.BeginUpdateStatus();
        }
    }


    /// <summary>
    /// The RestartState waits for the miner to stop then re-launches it.
    /// </summary>
    public class RestartState : IState
    {
        public IState Transition(AppEvent evt, AppStateMachine machine)
        {
            switch (evt)
            {
                case AppEvent.STOP_CLICKED:
                    return new StoppingState();
                case AppEvent.EXITED:
                    return new LaunchingState();
                default:
                    throw new InvalidStateTransitionException(this, evt);
            }
        }

        public override string ToString()
        {
            return "Restarting";
        }

        public void EnterState(AppStateMachine machine)
        {
            // Terminate any timers.
            machine.Form.StopTimeoutTimer();
            machine.Form.StopUpdateTimer();
            // Cancel pending WS update
            machine.Form.CancelUpdateStatus();
            // If we're already stopped, good.  Otherwise, wait.
            machine.Form.StopMiner();
        }
    }

    /// <summary>
    /// The Stopping state waits for the miner to exit then proceeds to idle.
    /// </summary>
    public class StoppingState : IState
    {
        public IState Transition(AppEvent evt, AppStateMachine machine)
        {
            switch (evt)
            {
                case AppEvent.EXITED:
                    return new IdleState();
                default:
                    throw new InvalidStateTransitionException(this, evt);
            }
        }

        public override string ToString()
        {
            return "Stopping";
        }

        public void EnterState(AppStateMachine machine)
        {
            // Terminate any timers.
            machine.Form.StopTimeoutTimer();
            machine.Form.StopUpdateTimer();
            // Cancel pending WS update
            machine.Form.CancelUpdateStatus();
            // If we're already stopped, good.  Otherwise, wait.
            machine.Form.StopMiner();
        }
    }
}
