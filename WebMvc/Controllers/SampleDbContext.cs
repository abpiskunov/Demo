using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class SampleDbContext : DbContext
    {
    }
}