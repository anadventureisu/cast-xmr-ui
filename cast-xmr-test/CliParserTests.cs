using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastXmrLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastXmrLib.Tests
{
    [TestClass()]
    public class CliParserTests
    {
        [TestMethod()]
        public void TestParseGPU()
        {
            CliParser clp = new CliParser(new AppState());

            clp.ParseLine("[07:46:03] GPU0 | 66°C | Fan 3280 RPM | 2044.1 H/s");
            Assert.AreEqual(66, clp.App.GpuStates[0].CurrentGpuTemp);
            Assert.AreEqual(3280, clp.App.GpuStates[0].CurrentFanSpeed);
            Assert.AreEqual(2044, clp.App.GpuStates[0].CurrentHashRate);

            clp.ParseLine("[07:46:08] GPU1 | 68°C | Fan 3286 RPM | 2035.2 H/s");
            Assert.AreEqual(68, clp.App.GpuStates[1].CurrentGpuTemp);
            Assert.AreEqual(3286, clp.App.GpuStates[1].CurrentFanSpeed);
            Assert.AreEqual(2035, clp.App.GpuStates[1].CurrentHashRate);

        }

        [TestMethod]
        public void TestParseStatus()
        {

            CliParser clp = new CliParser(new AppState());
            clp.ParseLine("[Hash Rate Avg: 2018.8 H/s]");
            clp.ParseLine("[Shares Found: 720 | Avg Search Time: 60.1 sec]");
            clp.ParseLine("692 ( 97%) Accepted");
            clp.ParseLine("  1 (  0%) Rejected by pool");
            clp.ParseLine("  2 (  0%) Invalid result computation failed");
            clp.ParseLine("  3 (  0%) Could not be submit because of network error");
            clp.ParseLine(" 22 (  3%) Outdated because of job change");

            Assert.AreEqual(720, clp.App.TotalShares);
            Assert.AreEqual(692, clp.App.SharesAccepted);
            Assert.AreEqual(1, clp.App.SharesRejected);
            Assert.AreEqual(2, clp.App.SharesInvalid);
            Assert.AreEqual(3, clp.App.SharesNetworkError);
            Assert.AreEqual(22, clp.App.SharesOutdated);

        }
    }
}