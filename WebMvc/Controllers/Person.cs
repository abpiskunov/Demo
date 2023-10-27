using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MailKit.Net.Smtp;

namespace WebMvc.Controllers
{
    [RequireHttpsAttribute]
    public class Person
    {
        public void Contact()
        {
            var q = System.Runtime.InteropServices.Marshal.GetActiveObject("");

            var w = System.Runtime.InteropServices.Marshal.ReleaseComObject("");

            var connectionString = "Data Source=xxx;Integrated Security=yes";

            var currentDir = Environment.CurrentDirectory;

            var tempFile = Path.GetTempFileName();

            System.IO.Compression.ZipFile.CreateFromDirectory("xxx", "yyy");

            var q2 = new System.Xml.XmlDocument();
            q2.Load("filename");

            ZipArchive zip = new ZipArchive(new MemoryStream());

            zip.ExtractToDirectory(tempFile);
        }

        public async Task EmailTest()
        {
            SmtpClient client = new SmtpClient();
            client.Send(null);
            await client.SendAsync(null);

            MailKit.Net.Imap.ImapClient imapClient = new MailKit.Net.Imap.ImapClient();

            var pop3Client = new MailKit.Net.Pop3.Pop3Client();

            var httpClient = new MailKit.Net.Proxy.HttpProxyClient("", 0);
        }
    }
}