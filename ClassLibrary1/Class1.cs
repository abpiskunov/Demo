using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    //public class Class1
    //{
    //    public void Test()
    //    {
    //        ZipArchive zip = new ZipArchive(new MemoryStream());

    //        zip.ExtractToDirectory("aaa");
    //    }
    //}

    internal static class NativeMethods
    {
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSection")]
        public static extern int WritePrivateProfileSectionXxx(string lpAppName, string lpString, string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern int WriteProfileSection(string lpAppName, string lpString, string lpFileName);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetShellWindow();

        public static void Test()
        {

        }
    }

    public class UsingIni
    {
        public void SomeMethod()
        {
            NativeMethods.WritePrivateProfileSectionXxx("", "", "");

            NativeMethods.Test();

            File.Delete("dddd");

            var psi = new ProcessStartInfo("cmd.exe", "/c dir /s");

            System.Diagnostics.EventLog.Delete("ssss");
        }
    }
}
