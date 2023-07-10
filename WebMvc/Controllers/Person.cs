using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class Person
    {
        public void Contact()
        {
            var q = System.Runtime.InteropServices.Marshal.GetActiveObject("");

            var w = System.Runtime.InteropServices.Marshal.ReleaseComObject("");

            var connectionString = "Data Source=xxx;Integrated Security=yes";
        }
    }
}