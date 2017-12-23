using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastXmrLib
{
    public class GpuSample
    {
        public long HashRate { get; private set; }
        public int FanSpeed { get; private set; }
        public int GpuTemp { get; private set; }
        public DateTime Timestamp { get; private set; }

        /// <summary>
        /// A Timestamped sample of GPU information.
        /// </summary>
        public GpuSample(DateTime timestamp, long hashRate, int fanSpeed, int gpuTemp)
        {
            Timestamp = timestamp;
            HashRate = hashRate;
            FanSpeed = fanSpeed;
            GpuTemp = gpuTemp;
        }
    }
}
