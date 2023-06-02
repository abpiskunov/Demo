using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    [Bind(Exclude = "Qqq")]
    public class Model
    {
        public string Qqq { get; }
    }
}