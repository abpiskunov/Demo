using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace WebMvc.Controllers
{
    [Bind]
    public class Model
    {
        [BindNever] public string Qqq { get; }
    }
}