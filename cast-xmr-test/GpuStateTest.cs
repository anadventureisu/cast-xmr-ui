
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastXmrLib;

namespace CastXmrLibTest
{
    [TestClass]
    public class GpuStateTest
    {
        [TestMethod]
        public void TestDefault()
        {
            GpuState state = new GpuState();
            Assert.AreEqual(0, state.CurrentFanSpeed);
            Assert.AreEqual(0, state.CurrentGpuTemp);
            Assert.AreEqual(0, state.CurrentHashRate);
            Assert.AreEqual(0.0, state.FiveMinHashAvg);
            Assert.AreEqual(0.0, state.OneHourHashAvg);
            Assert.IsNotNull(state.Samples);
            Assert.AreEqual(0, state.Samples.Count);
        }

        [TestMethod]
        public void TestCurrent()
        {
            GpuState state = CreateGpuState();

            Assert.AreEqual(2000, state.CurrentHashRate);
            Assert.AreEqual(50, state.CurrentGpuTemp);
            Assert.AreEqual(3000, state.CurrentFanSpeed);
        }

        [TestMethod]
        public void TestFiveMinAvg()
        {
            GpuState state = CreateGpuState();

            state.UpdateAverages();
            Assert.AreEqual(2000.0, state.FiveMinHashAvg);
        }

        [TestMethod]
        public void TestOneHourAvg()
        {
            GpuState state = CreateGpuState();

            state.UpdateAverages();
            Assert.AreEqual(1250.0, state.OneHourHashAvg);
        }

        [TestMethod]
        public void TestPrune()
        {
            GpuState state = CreateGpuState();

            Assert.AreEqual(10, state.Samples.Count);

            // Since this test can run fast, need to do one second less.
            state.PruneSamplesOlderThan(TimeSpan.FromSeconds(3599));

            Assert.AreEqual(8, state.Samples.Count);
        }

        [TestMethod]
        public void TestClear()
        {
            GpuState state = CreateGpuState();

            Assert.AreEqual(10, state.Samples.Count);

            state.Clear();

            Assert.AreEqual(0, state.Samples.Count);

        }

        /// <summary>
        /// Create a mock object with some samples.
        /// </summary>
        /// <returns></returns>
        private GpuState CreateGpuState()
        {
            GpuState state = new GpuState();

            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(65), 1000, 3009, 59));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(60), 1000, 3008, 58));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(59), 1000, 3007, 57));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(31), 1000, 3006, 56));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(30), 1000, 3005, 55));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(29), 1000, 3004, 54));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(6), 1000, 3003, 53));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(5), 1000, 3002, 52));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(1), 2000, 3001, 51));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(0), 2000, 3000, 50));

            return state;
        }
    }
}
