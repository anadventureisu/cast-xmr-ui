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
    public class Devcon
    {
        public const string AMD_VEGA = @"PCI\VEN_1002&DEV_687";

        // Some P/Invoke constants
        private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        const UInt32 DIGCF_DEFAULT = 0x1;
        const UInt32 DIGCF_PRESENT = 0x2;
        const UInt32 DIGCF_ALLCLASSES = 0x4;
        const UInt32 DIGCF_PROFILE = 0x8;
        const UInt32 DIGCF_DEVICEINTERFACE = 0x10;

        /// https://msdn.microsoft.com/en-us/library/windows/hardware/ff551069(v=vs.85).aspx
        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr SetupDiGetClassDevs(
            IntPtr ClassGuid,
            string Enumerator,
            IntPtr hwndParent,
            UInt32 Flags);

        /// <summary>
        /// The SetupDiDestroyDeviceInfoList function deletes a device information set and frees all associated memory.
        /// https://msdn.microsoft.com/en-us/library/windows/hardware/ff550996(v=vs.85).aspx
        /// </summary>
        /// <param name="DeviceInfoSet">The device info list to cleanup</param>
        /// <returns>The function returns TRUE if it is successful. Otherwise, it returns FALSE and the logged error can be retrieved with a call to GetLastError.</returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        public static extern bool SetupDiDestroyDeviceInfoList(
            IntPtr DeviceInfoSet);

        [StructLayout(LayoutKind.Sequential)]
        public struct SP_DEVINFO_DATA
        {
            public uint cbSize;
            public Guid classGuid;
            public uint devInst;
            public IntPtr reserved;
        }

        /// <summary>
        /// The SetupDiEnumDeviceInfo function returns a SP_DEVINFO_DATA structure that specifies a device information element in a device information set.
        /// https://msdn.microsoft.com/en-us/library/windows/hardware/ff551010(v=vs.85).aspx
        /// </summary>
        /// <param name="DeviceInfoSet">A handle to the device information set for which to return an SP_DEVINFO_DATA structure that represents a device information element.</param>
        /// <param name="MemberIndex">A zero-based index of the device information element to retrieve.</param>
        /// <param name="DeviceInfoData">A pointer to an SP_DEVINFO_DATA structure to receive information about an enumerated device information element. The caller must set DeviceInfoData.cbSize to sizeof(SP_DEVINFO_DATA).</param>
        /// <returns>The function returns TRUE if it is successful. Otherwise, it returns FALSE and the logged error can be retrieved with a call to GetLastError.</returns>
        [DllImport("setupapi.dll", SetLastError = true)]
        public static extern bool SetupDiEnumDeviceInfo(IntPtr DeviceInfoSet, uint MemberIndex, ref SP_DEVINFO_DATA DeviceInfoData);

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

        /// <summary>
        /// Enable a device driver.  Ported from Microsoft sample code.
        /// https://github.com/Microsoft/Windows-driver-samples/blob/master/setup/devcon/cmds.cpp#L861
        /// </summary>
        public static void Disable(string BaseName)
        {
            

            // OK, now we should have a device list.

        }

        public static IntPtr GetDrivers()
        {
            IntPtr hDeviceInfoList = SetupDiGetClassDevs(IntPtr.Zero, null, IntPtr.Zero, 
                DIGCF_PRESENT|DIGCF_ALLCLASSES);
            // Success?
            if (hDeviceInfoList == INVALID_HANDLE_VALUE)
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            return hDeviceInfoList;
        }

        public static bool FreeDriver(IntPtr hDeviceInfoList)
        {
            return SetupDiDestroyDeviceInfoList(hDeviceInfoList);
        }
    }
}
