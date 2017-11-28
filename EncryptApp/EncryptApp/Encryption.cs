using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp
{
    public enum Algorithms
    {
        AES128,
        AES256
    }

    public static class Encryption
    {
        public static Algorithm[] encryptionAlgorithms = new Algorithm[2]
        {
            new AES(128),
            new AES(256)
        };

        public static List<string> GetFileExtensions()
        {
            List<string> extensions = new List<string>();
            foreach (Algorithm algorithm in encryptionAlgorithms)
            {
                if (!extensions.Contains(algorithm.FileExtension))
                {
                    extensions.Add(algorithm.FileExtension);
                }
            }
            return extensions;
        }

        public static byte[] Encrypt(Algorithms algorithm, byte[] input, byte[] key)
        {
            Algorithm[] algorithms = Encryption.encryptionAlgorithms;
            Algorithm algorithmObject = algorithms[(int)algorithm];
            return algorithmObject.Encrypt(input, key);
        }

        public static byte[] Decrypt(Algorithms algorithm, byte[] input, byte[] key)
        {
            return encryptionAlgorithms[(int)algorithm].Decrypt(input, key);
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
