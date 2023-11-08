using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;

namespace ClassLibrary
{
    public class Class1
    {
        public void TestMethod()
        {
            var readerC = new StreamReader("somepath");


            var s1 = @"d:" + "\\xx";

            var s2 = "w:\\xx\\somefolder\\qq.txt";

            var s3 = Environment.ExpandEnvironmentVariables(@"%SystemDrive%\\xx\\somefolder\\qq.txt");

            File.Copy("aa", "bb");

            var zzz = new System.Diagnostics.DelimitedListTraceListener("");

            var tt = new XmlWriterTraceListener("qq");

            GlobalConfiguration.Configuration
                .UseRedisStorage("<name or connection string>");

            CoreWCF.NetTcpBinding binding = new CoreWCF.NetTcpBinding();
        }
    }
}
