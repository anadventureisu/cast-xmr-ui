using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CastXmrLib
{
    public class CliParser
    {
        public AppState App { get; private set; }

        // status line: [07:46:03] GPU0 | 66.C | Fan 3280 RPM | 2044.1 H/s
        private Regex StatusLine = new Regex(@"^\[(.*)\] GPU([0-9]+) \| ([0-9]+).C \| Fan ([0-9]+) RPM \| ([0-9\.]+) H\/s");

        // Statistics: 692 ( 97%) Accepted
        private Regex StatisticLine = new Regex(@"^[\s]*([0-9]+) \([\s]*([0-9]+)%\) (.*)");

        private const string ACCEPTED = "Accepted";
        private const string REJECTED = "Rejected by pool";
        private const string INVALID = "Invalid result computation failed";
        private const string NETWORK = "Could not be submit because of network error";
        private const string OUTDATED = "Outdated because of job change";

        public CliParser(AppState app)
        {
            App = app;
        }

        public void ParseLine(string line)
        {
            Match m = null;
            if ((m = StatusLine.Match(line)).Success)
            {
                try
                {
                    string timestamp = m.Groups[1].Captures[0].Value;
                    int gpuIndex = int.Parse(m.Groups[2].Captures[0].Value);
                    int gpuTemp = int.Parse(m.Groups[3].Captures[0].Value);
                    int gpuRpm = int.Parse(m.Groups[4].Captures[0].Value);
                    double gpuHashrate = double.Parse(m.Groups[5].Captures[0].Value);

                    GpuSample samp = new GpuSample(DateTime.Now, (long)gpuHashrate, gpuRpm, gpuTemp);

                    // Get GPU.
                    GpuState gpu = App.GetGpu(gpuIndex);

                    gpu.AddSample(samp);
                } catch(FormatException e)
                {
                    Debug.WriteLine("Could not parse line: " + line + ": " + e);
                }
            }
            else if ((m = StatisticLine.Match(line)).Success)
            {
                try
                {
                    int stat = int.Parse(m.Groups[1].Captures[0].Value);
                    string msg = m.Groups[3].Captures[0].Value;

                    if(ACCEPTED.Equals(msg))
                    {
                        App.SharesAccepted = stat;
                    }
                    else if (REJECTED.Equals(msg))
                    {
                        App.SharesRejected = stat;
                    }
                    else if (INVALID.Equals(msg))
                    {
                        App.SharesInvalid = stat;
                    }
                    else if (NETWORK.Equals(msg))
                    {
                        App.SharesNetworkError = stat;
                    }
                    else if (OUTDATED.Equals(msg))
                    {
                        App.SharesOutdated = stat;
                    }

                    App.TotalShares = App.SharesAccepted + App.SharesInvalid + App.SharesNetworkError + App.SharesOutdated + App.SharesRejected;
                }
                catch (FormatException e)
                {
                    Debug.WriteLine("Could not parse line: " + line + ": " + e);
                }
            }
        }
    }
}
