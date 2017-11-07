using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp
{
    public abstract class Algorithm
    {
        public abstract string Encrypt(string input, string key);
        public abstract string Decrypt(string input, string key);
    }
}
