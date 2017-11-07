using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp
{
    public enum Algorithms
    {
        AES
    }

    public static class Encryption
    {
        private static Algorithm AES = new AES();
        private static Algorithm[] encryptionAlgorithms = new Algorithm[]
        {
            AES
        };

        public static string Encrypt(Algorithms algorithm, string input, string key)
        {
            // TO-DO
            return encryptionAlgorithms[(int)algorithm].Encrypt(input, key);
        }

        public static string Decrypt(Algorithms algorithm, string input, string key)
        {
            // TO-DO
            return encryptionAlgorithms[(int)algorithm].Decrypt(input, key);
        }
    }
}
