using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp
{
    public abstract class Algorithm
    {
        public string FileExtension { get; protected set; }
        public abstract byte[] Encrypt(byte[] input, byte[] key);
        public abstract byte[] Decrypt(byte[] input, byte[] key);
    }
}
