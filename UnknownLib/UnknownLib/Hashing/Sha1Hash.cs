using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Hashing
{
    internal class Sha1Hash : IHash
    {
        SHA1 sHA1 = SHA1.Create();
        public string Hash(string input)
        {
            return Convert.ToBase64String(sHA1.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input)
        {
            return sHA1.ComputeHash(input);
        }
    }
}
