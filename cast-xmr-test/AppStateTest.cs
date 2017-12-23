using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastXmrLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CastXmrLibTest
{
    [TestClass]
    public class AppStateTest
    {
        [TestMethod]
        public void TestZeroGPUs()
        {
            // Guard against divide by zero
            AppState app = new AppState();

            app.UpdateGlobalRates();

            Assert.AreEqual(0.0, app.CurrentGlobalRate);
            Assert.AreEqual(0.0, app.FiveMinGlobalRate);
            Assert.AreEqual(0.0, app.OneHourGlobalRate);
            Assert.AreEqual(0, app.GpuStates.Count());
            Assert.AreEqual(DateTime.MinValue, app.StartTime);
        }

        [TestMethod]
        public void TestOneGPU()
        {
            AppState app = new AppState();

            app.GpuStates[0] = CreateGpuState();

            app.UpdateGlobalRates();

            Assert.AreEqual(2000.0, app.CurrentGlobalRate);
            Assert.AreEqual(2000.0, app.FiveMinGlobalRate);
            Assert.AreEqual(1250.0, app.OneHourGlobalRate);
            Assert.AreEqual(1, app.GpuStates.Count());
        }

        private GpuState CreateGpuState()
        {
            GpuState state = new GpuState();

            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(65), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(60), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(59), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(31), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(30), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(29), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(6), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(5), 1000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(1), 2000, 3000, 50));
            state.AddSample(new GpuSample(DateTime.Now - TimeSpan.FromMinutes(0), 2000, 3000, 50));
            state.UpdateAverages();

            return state;
        }
    }


}
