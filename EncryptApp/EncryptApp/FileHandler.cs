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
        public static string ReadFile(string filelocation)
        {
            if (File.Exists(filelocation))
            {
                return File.ReadAllText(filelocation);
            }
            return String.Empty;
        }

        public static void WriteFile(string filelocation, string data)
        {
            File.WriteAllText(filelocation, data);
        }
    }
}
