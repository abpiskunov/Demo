using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MassTransit;
using Microsoft.Win32;

namespace WebMvc.Controllers
{
    public class Sample1
    {
        public void Contact()
        {
            var oledbCommand = new OleDbCommand("SELECT * FROM table");

            var w = System.Runtime.InteropServices.Marshal.ReleaseComObject("");

            var r = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);

            var m = RabbitMQ.Client.ConnectionFactory.DefaultUser;

            var t = MassTransit.Bus.Factory.CreateUsingRabbitMq(null);
        }
    }
}