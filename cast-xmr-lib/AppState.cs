using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastXmrLib
{
    public class AppState
    {
        public double CurrentGlobalRate { get; private set; }
        public double FiveMinGlobalRate { get; private set; }
        public double OneHourGlobalRate { get; private set; }

        // stats
        public int SharesAccepted { get; set; }
        public int SharesRejected { get; set; }
        public int SharesInvalid { get; set; }
        public int SharesNetworkError { get; set; }
        public int SharesOutdated { get; set; }
        public int TotalShares { get; set; }

        public DateTime StartTime { get; set; }
        

        public Dictionary<int,GpuState> GpuStates { get; private set; }

        public AppState()
        {
            GpuStates = new Dictionary<int, GpuState>();
        }

        public GpuState GetGpu(int index)
        {
            if(!GpuStates.ContainsKey(index))
            {
                GpuState s = new GpuState();
                GpuStates[index] = s;
            }
            return GpuStates[index];
        }

        public void UpdateGlobalRates()
        {
            double currentRate = 0.0;
            double fiveRate = 0.0;
            double hourRate = 0.0;

            if(GpuStates.Count == 0)
            {
                CurrentGlobalRate = 0.0;
                FiveMinGlobalRate = 0.0;
                OneHourGlobalRate = 0.0;
            } else
            {
                foreach (var gpu in GpuStates.Values)
                {
                    currentRate += gpu.CurrentHashRate;
                    fiveRate += gpu.FiveMinHashAvg;
                    hourRate += gpu.OneHourHashAvg;
                }
                CurrentGlobalRate = currentRate;
                FiveMinGlobalRate = fiveRate;
                OneHourGlobalRate = hourRate;
            }
            
        }
    }
}
