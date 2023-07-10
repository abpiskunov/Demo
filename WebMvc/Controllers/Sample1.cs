using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MassTransit;
using Microsoft.Win32;
using Serilog;

namespace WebMvc.Controllers
{
    public class Sample1
    {
        public Sample1()
        {

        }

        public void Contact()
        {
            //List<string> qq = new();
            var reader = new StreamReader("somepath");
            var reader3 = new System.IO.StreamReader(new MemoryStream());
            var oledbCommand = new OleDbCommand("SELECT * FROM table"); 

            var w = System.Runtime.InteropServices.Marshal.ReleaseComObject("");

            var r = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);

            var m = RabbitMQ.Client.ConnectionFactory.DefaultUser;

            var t = MassTransit.Bus.Factory.CreateUsingRabbitMq(null);

            var somepath = "";
            var f1 = File.ReadAllText(somepath);

            var s1 = @"d:" + "\\xx";

            var s2 = "w:\\xx\\somefolder\\qq.txt";

            var s3 = Environment.ExpandEnvironmentVariables(@"%SystemDrive%\\xx\\somefolder\\qq.txt");

            var image = System.Drawing.Image.FromFile("somepath");

            File.Copy("aa", "bb");

            var zzz = new System.Diagnostics.DelimitedListTraceListener("");

            var tt = new XmlWriterTraceListener("qq");

            var q1 = new log4net.Appender.ColoredConsoleAppender();

            var serilog = new LoggerConfiguration().WriteTo.File("");

            var message = new System.Messaging.AccessControlEntry();

            System.Net.WebRequest request = null;
            request.UseDefaultCredentials = true;

            var q4 = new System.Net.NetworkCredential();

            var q5 = new System.Runtime.Caching.MemoryCache("cache");

            var q6 = System.Web.HttpContext.Current.Cache;
        }
    }
}