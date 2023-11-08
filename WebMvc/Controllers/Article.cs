using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace WebMvc.Controllers
{
    public class Article
    {
        public void Contact()
        {
            var q = new HttpClient();

            System.Data.SqlClient.SortOrder w = new System.Data.SqlClient.SortOrder();

            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand();

            System.Net.WebRequest q2 = null;

            System.Net.Mail.Attachment attachment = null;

            var w1 = System.Security.Cryptography.HashAlgorithmName.SHA1;

            var w2 = CngAlgorithm.Sha1;

            System.Web.Security.FormsAuthentication.Encrypt(null);

            System.Web.Security.MachineKey.Protect(null);

            var ss = System.Net.WebSockets.ClientWebSocket.CreateServerBuffer(1);

            System.DirectoryServices.
        }

        public string Encrypt()
        {
            var x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes("some text");
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();

        }
    }
}