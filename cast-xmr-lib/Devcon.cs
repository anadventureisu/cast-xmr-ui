using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CastXmrLib
{
    /// <summary>
    /// Managed code bridge to driver Enable/Disable functionality included
    /// with devcon.exe.
    /// 
    /// </summary>
    class Devcon
    {
        public const string AMD_VEGA = @"PCI\VEN_1002&DEV_687";

        // Some P/Invoke constants
        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        /// https://msdn.microsoft.com/en-us/library/windows/hardware/ff551069(v=vs.85).aspx
        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr SetupDiGetClassDevs(
            IntPtr ClassGuid,
            string Enumerator,
            IntPtr hwndParent,
            int Flags);

        /// <summary>
        /// The SetupDiDestroyDeviceInfoList function deletes a device information set and frees all associated memory.
        /// https://msdn.microsoft.com/en-us/library/windows/hardware/ff550996(v=vs.85).aspx
        /// </summary>
        /// <param name="DeviceInfoSet">The device info list to cleanup</param>
        /// <returns>The function returns TRUE if it is successful. Otherwise, it returns FALSE and the logged error can be retrieved with a call to GetLastError.</returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        public static extern bool SetupDiDestroyDeviceInfoList(
            IntPtr DeviceInfoSet);

        /// <summary>
        /// Enable a device driver.  Ported from Microsoft sample code.
        /// https://github.com/Microsoft/Windows-driver-samples/blob/master/setup/devcon/cmds.cpp#L861
        /// </summary>
        public static void Enable(string BaseName)
        {
            IntPtr hDeviceInfoList = SetupDiGetClassDevs(IntPtr.Zero, BaseName, IntPtr.Zero, 0);
            // Success?
            if(hDeviceInfoList == INVALID_HANDLE_VALUE)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
            
            // OK, now we should have a device list.

        }
    }
}
