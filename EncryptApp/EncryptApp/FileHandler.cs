using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncryptApp
{
    public static class FileHandler
    {
        public static byte[] ReadFile(string filelocation)
        {
            if (File.Exists(filelocation))
            {
                return File.ReadAllBytes(filelocation);
            }
            return null;
        }

        public static void WriteFile(string filelocation, byte[] data)
        {
            File.WriteAllBytes(filelocation, data);
        }
    }
}
