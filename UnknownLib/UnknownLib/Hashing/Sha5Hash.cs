using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Hashing
{
    internal class Sha5Hash : IHash
    {
        SHA512 sHA512 = SHA512.Create();
        public string Hash(string input)
        {
            return Convert.ToBase64String(sHA512.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input)
        {
            return sHA512.ComputeHash(input);
        }
    }
}
