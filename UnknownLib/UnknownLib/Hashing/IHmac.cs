using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Hashing
{
    internal interface IHmac : IHash
    {
        string Hash(string input, string password);
        byte[] Hash(byte[] input, byte[] password);
    }
}
