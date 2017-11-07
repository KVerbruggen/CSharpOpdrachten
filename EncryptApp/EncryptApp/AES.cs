using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptApp
{
    public class AES : Algorithm
    {
        public AES()
        {
            FileExtension = "AES Files (*.aes)|*.aes";
        }
        public override string Encrypt(string input, string key)
        {
            // TO-DO: Implement AES
            return "AES Encrypted using key '" + key + "': " + input;
        }

        public override string Decrypt(string input, string key)
        {
            // TO-DO: Implement AES
            return "AES Decrypted using key '" + key + "': " + input;
        }
    }
}
