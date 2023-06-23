using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.Controllers
{
    public class Article
    {
        public void Contact()
        {
            var q = new HttpClient();

            System.Data.SqlClient.SortOrder w = new System.Data.SqlClient.SortOrder();

            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();
        }
    }
}