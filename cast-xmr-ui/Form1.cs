using CastXmrLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cast_xmr_ui
{
    public partial class Form1 : Form
    {
        private AppState app = new AppState();
        DateTime minerStarted;
        private int restartCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void processRunner_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            consoleLog.AppendText(e.Data + "\n");
            Debug.WriteLine("STDOUT: " + e.Data);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            consoleLog.Clear();

            if(String.IsNullOrEmpty(exePath.Text))
            {
                MessageBox.Show("Please specify a miner path");
                return;
            }
            if(!File.Exists(exePath.Text))
            {
                MessageBox.Show("Miner path does not exist");
                return;
            }

            // Arg check
            if (poolAddress.Text.Count() < 1)
            {
                throw new ArgumentNullException("PoolAddress");
            }
            if (walletAddress.Text.Count() < 1)
            {
                throw new ArgumentNullException("WalletAddress");
            }

            startMiner();

            startButton.Enabled = false;
            stopButton.Enabled = true;
            //processRunner.BeginErrorReadLine();
            //processRunner.BeginOutputReadLine();

            statusTimer.Start();

            // Save the settings
            Properties.Settings.Default.Save();
        }

        private void startMiner()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            //info.RedirectStandardError = true;
            //info.RedirectStandardInput = true;
            //info.RedirectStandardOutput = true;
            //info.CreateNoWindow = true;
            info.UseShellExecute = false;
            info.FileName = exePath.Text;
            info.ErrorDialog = true;
            StringBuilder args = new StringBuilder();

            args.Append("--pool " + poolAddress.Text);
            args.Append(" --user " + walletAddress.Text);
            if (workerPassword.Text.Count() > 0)
            {
                args.Append(" --password " + workerPassword.Text);
            }
            args.Append(" --intensity " + intensity.Value);

            if (useNicehash.Checked)
            {
                args.Append(" --nicehash");
            }

            if (fastJobCheck.Checked)
            {
                args.Append(" --fastjobswitch");
            }

            args.Append(" -G " + gpuText.Text);
            args.Append(" --remoteaccess");
            info.Arguments = args.ToString();

            processRunner.StartInfo = info;

            Debug.WriteLine("Args: " + args);

            consoleLog.AppendText("STARTING: " + processRunner.StartInfo.FileName + " " + processRunner.StartInfo.Arguments + Environment.NewLine);
            try
            {
                processRunner.Start();
            } catch(Exception e)
            {
                MessageBox.Show("Could not start miner: " + e.Message, "Error");
            }
            minerStarted = DateTime.Now;
        }

        private void processRunner_Exited(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void processRunner_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            consoleLog.AppendText("STDERR: " + e.Data + "\n");

        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            //processRunner.StandardInput.Write('s');
            //processRunner.StandardInput.Flush();
            WebClient wc = new WebClient();
            try {
                string response = wc.DownloadString("http://localhost:7777");
                JsonParser.Parse(response, app);
                app.UpdateGlobalRates();

                printStatus();

                int restartRate = int.Parse(hashRestart.Text);

                if (autoRestartCheck.Checked && (DateTime.Now - minerStarted > TimeSpan.FromMinutes(5)))
                {
                    foreach (int gpu in app.GpuStates.Keys)
                    {
                        GpuState gs = app.GetGpu(gpu);
                        if (gs.FiveMinHashAvg < restartRate)
                        {
                            consoleLog.AppendText(String.Format("RESTARTING MINER - rate {0:N0} < {1:N0}\n", gs.FiveMinHashAvg, restartRate));
                            statusTimer.Stop();
                            processRunner.Kill();
                            startMiner();
                            statusTimer.Start();
                            restartCount++;
                            restartLabel.Text = String.Format("{0} restarts", restartCount);
                            break;
                        }
                    }
                }
                
            }
            catch (Exception ee)
            {
                consoleLog.AppendText("ERROR: could not query web service: " + ee.Message + "\n");
            }
        }

        private void printStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}: Rate: {1:N0}:5s {2:N0}:5m {3:N0}:1h - ", DateTime.Now.ToLongTimeString(), app.CurrentGlobalRate, app.FiveMinGlobalRate, app.OneHourGlobalRate);
            foreach(int gpu in app.GpuStates.Keys)
            {
                GpuState gs = app.GetGpu(gpu);
                sb.AppendFormat("GPU{0}: {1}H/s {2}C {3}RPM ", gpu, gs.CurrentHashRate, gs.CurrentGpuTemp, gs.CurrentFanSpeed);
            }
            sb.Append("\n");
            consoleLog.AppendText(sb.ToString());
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            statusTimer.Stop();
            processRunner.Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(chooseMinerDialog.ShowDialog() == DialogResult.OK)
            {
                exePath.Text = chooseMinerDialog.FileName;
            }
        }
    }
}
