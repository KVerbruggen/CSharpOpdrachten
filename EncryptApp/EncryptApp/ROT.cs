using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EncryptApp
{
    public class ROT : Algorithm
    {

        public ROT(string name)
        {
            Name = name;
        }

        public override byte[] Encrypt(byte[] contentBytes, byte[] passwordBytes)
        {
            int key = 0;
            foreach (byte b in passwordBytes)
            {
                key = (key + (int)b) % 26;
            }
            return Encrypt(contentBytes, key);
        }

        public byte[] Encrypt(byte[] contentBytes, int key)
        {
            for (int i = 0; i < contentBytes.Count(); i++)
            {
                if ((int)contentBytes[i] >= 65 && (int)contentBytes[i] <= 90)
                {
                    contentBytes[i] = (byte)(((contentBytes[i] - 65 + key) % 26) + 65);
                }
                else if ((int)contentBytes[i] >= 97 && (int)contentBytes[i] <= 122)
                {
                    contentBytes[i] = (byte)(((contentBytes[i] - 97 + key) % 26) + 97);
                }
            }
            return contentBytes;
        }

        public override byte[] Decrypt(byte[] contentBytes, byte[] passwordBytes)
        {
            return Encrypt(contentBytes, passwordBytes);
        }

        public byte[] Decrypt(byte[] contentBytes, int key)
        {
            return Encrypt(contentBytes, key);
        }
    }
}
