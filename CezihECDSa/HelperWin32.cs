using System.Runtime.InteropServices;
using System.Text;

namespace CezihECDSa
{
    internal class HelperWin32
    {
        private const string KERNEL32_DLL = "kernel32.dll";

        [DllImport(KERNEL32_DLL, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);
    }
}