using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Test()
        {
            ZipArchive zip = new ZipArchive(new MemoryStream());

            zip.ExtractToDirectory("aaa");
        }
    }
}
