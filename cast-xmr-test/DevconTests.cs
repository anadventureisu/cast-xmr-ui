using Microsoft.VisualStudio.TestTools.UnitTesting;
using CastXmrLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CastXmrLib.Tests
{
    [TestClass()]
    public class DevconTests
    {
        [TestMethod()]
        public void GetDriversTest()
        {
            IntPtr driver = Devcon.GetDrivers();
            Assert.AreNotEqual(IntPtr.Zero, driver);
            bool success = Devcon.FreeDriver(driver);
            Assert.IsTrue(success);

        }

        [TestMethod()]
        public void TestEnumeratingDrivers()
        {
            IntPtr driverSet = Devcon.GetDrivers();
            Assert.AreNotEqual(IntPtr.Zero, driverSet);

            Devcon.SP_DEVINFO_DATA devinfo = new Devcon.SP_DEVINFO_DATA();
            devinfo.cbSize = (uint)Marshal.SizeOf(devinfo);

            uint index = 0;
            while (Devcon.SetupDiEnumDeviceInfo(
                             driverSet,
                             index,
                             ref devinfo))
            {
                index++;
            }

            Assert.IsTrue(index > 0);

            bool success = Devcon.FreeDriver(driverSet);
            Assert.IsTrue(success);
        }
    }
}