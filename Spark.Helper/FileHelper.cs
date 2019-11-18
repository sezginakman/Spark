using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spark.Helper
{
    public class FileHelper
    {
        public static byte[] FileToByteArray(string fileName)
        {
            byte[] fileData = null;
            using (var fs = File.OpenRead(fileName))
            using (var binaryReader = new BinaryReader(fs))
                fileData = binaryReader.ReadBytes((int)fs.Length);
            return fileData;
        }
    }
}
