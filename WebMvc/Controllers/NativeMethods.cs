// Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace WebMvc.Controllers
{
    internal static class NativeMethods
    {
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileSection")]
        public static extern int WritePrivateProfileSectionXxx(string lpAppName, string lpString, string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern int WriteProfileSection(string lpAppName, string lpString, string lpFileName);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetShellWindow();
    } 

    public class UsingIni
    {
        public void SomeMethod()
        {
            NativeMethods.WritePrivateProfileSectionXxx("", "", "");
        }
    }
}
