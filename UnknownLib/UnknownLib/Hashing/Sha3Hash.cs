using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Hashing
{
    internal class Sha3Hash : IHash
    {
        SHA384 sHA384 = SHA384.Create();
        public string Hash(string input)
        {
            return Convert.ToBase64String(sHA384.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input)
        {
            return sHA384.ComputeHash(input);
        }
    }
}
