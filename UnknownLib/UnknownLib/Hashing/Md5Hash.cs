using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Hashing
{
    internal class Md5Hash
    {
        MD5 mD5 = MD5.Create();

        public byte[] Hash(byte[] input)
        {
            return mD5.ComputeHash(input);
        }

        public string Hash(string input)
        {
            return Convert.ToBase64String(mD5.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }
    }
}
