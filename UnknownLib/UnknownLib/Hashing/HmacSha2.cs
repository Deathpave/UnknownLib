﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Hashing
{
    internal class HmacSha2 : IHmac
    {
        HMACSHA256 hMACSHA256 = new HMACSHA256();
        public string Hash(string input, string password)
        {
            hMACSHA256.Key = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(hMACSHA256.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input, byte[] password)
        {
            hMACSHA256.Key = password;
            return hMACSHA256.ComputeHash(input);
        }
    }
}
