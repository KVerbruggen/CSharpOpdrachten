using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp
{

    public static class Encryption
    {
        public static List<Algorithm> encryptionAlgorithms = new List<Algorithm>();

        static Encryption()
        {
            encryptionAlgorithms.Add(new AES("AES128", 128));
            encryptionAlgorithms.Add(new AES("AES256", 256));
            encryptionAlgorithms.Add(new ROT("ROT-n"));
        }

        public static List<string> GetFileExtensions()
        {
            List<string> extensions = new List<string>();
            foreach (Algorithm algorithm in encryptionAlgorithms)
            {
                if (!extensions.Contains(algorithm.FileExtension) && algorithm.FileExtension != String.Empty)
                {
                    extensions.Add(algorithm.FileExtension);
                }
            }
            return extensions;
        }

        public static byte[] Encrypt(Algorithm algorithm, byte[] input, byte[] key)
        {
            return algorithm.Encrypt(input, key);
        }

        public static byte[] Decrypt(Algorithm algorithm, byte[] input, byte[] key)
        {
            return algorithm.Decrypt(input, key);
        }

        public static bool SaveToFile(string savelocation, byte[] content)
        {
            bool fileFound = savelocation != null && savelocation != String.Empty;
            if (fileFound)
            {
                FileHandler.WriteFile(savelocation, content);
            }
            return fileFound;
        }
    }
}
