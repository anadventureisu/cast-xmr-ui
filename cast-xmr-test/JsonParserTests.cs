using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastXmrLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CastXmrLib.Tests
{
    [TestClass()]
    public class JsonParserTests
    {

        [TestMethod()]
        public void ParseTest()
        {
            AppState state = new AppState();

            string json = File.ReadAllText("test1.json");
            JsonParser.Parse(json, state);

            Assert.AreEqual(38, state.SharesAccepted);
            Assert.AreEqual(1, state.SharesRejected);
            Assert.AreEqual(2, state.SharesInvalid);
            Assert.AreEqual(3, state.SharesNetworkError);
            Assert.AreEqual(4, state.SharesOutdated);
            Assert.AreEqual(48, state.TotalShares);

            Assert.AreEqual(2, state.GpuStates.Count);

            GpuState gpu0 = state.GetGpu(0);
            Assert.AreEqual(2030594, gpu0.CurrentHashRate);
            Assert.AreEqual(51, gpu0.CurrentGpuTemp);
            Assert.AreEqual(3810, gpu0.CurrentFanSpeed);

            GpuState gpu1 = state.GetGpu(1);
            Assert.AreEqual(2023334, gpu1.CurrentHashRate);
            Assert.AreEqual(53, gpu1.CurrentGpuTemp);
            Assert.AreEqual(3846, gpu1.CurrentFanSpeed);

            Assert.AreEqual(4053928, state.CurrentGlobalRate);
        }

    }
}