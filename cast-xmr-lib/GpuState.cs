using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastXmrLib
{
    /// <summary>
    /// Holds the state for a particular GPU
    /// </summary>
    public class GpuState
    {
        public long CurrentHashRate { get; private set; }
        public int CurrentFanSpeed { get; private set; }
        public int CurrentGpuTemp { get; private set; }

        public double FiveMinHashAvg { get; private set; }

        public double OneHourHashAvg { get; private set; }

        public List<GpuSample> Samples { get; private set; }

        public GpuState()
        {
            Samples = new List<GpuSample>();
        }

        public void AddSample(GpuSample sample)
        {
            Samples.Add(sample);
            CurrentHashRate = sample.HashRate;
            CurrentGpuTemp = sample.GpuTemp;
            CurrentFanSpeed = sample.FanSpeed;
        }

        public void PruneSamplesOlderThan(TimeSpan maxAge)
        {
            Samples.RemoveAll(x => DateTime.Now - x.Timestamp > maxAge);
        }

        public void UpdateAverages()
        {
            FiveMinHashAvg = GetAverage(Samples.FindAll(x => DateTime.Now - x.Timestamp < TimeSpan.FromMinutes(5)));
            OneHourHashAvg = GetAverage(Samples.FindAll(x => DateTime.Now - x.Timestamp < TimeSpan.FromMinutes(60)));
        }

        public void Clear()
        {
            Samples.Clear();
            CurrentFanSpeed = 0;
            CurrentGpuTemp = 0;
            CurrentHashRate = 0;
            FiveMinHashAvg = 0.0;
            OneHourHashAvg = 0.0;
        }

        private double GetAverage(List<GpuSample> list)
        {
            double sum = 0;
            foreach (var item in list)
            {
                sum += item.HashRate;
            }
            
            return sum / list.Count;
        }

    }
}
