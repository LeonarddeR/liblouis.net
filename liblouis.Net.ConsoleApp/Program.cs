using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace liblouis.Net.ConsoleApp
{
    public class Program
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDllDirectory(string lpPathName);

        static void Main()
        {
            SetDllDirectory(@"C:\Program Files (x86)\NVDA");
            String intje = "hoi";
            Encoding encorder = Encoding.UTF32;
            byte[] haj = encorder.GetBytes(intje);
            byte[] outje = null;
            int length = 0;
            int result = Library.lou_charToDots(@"louis\tables\nl-comp8.utb", haj, outje, length, 0);
        }
    }
}
