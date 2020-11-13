using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Binary
{
    class FromBinary
    {
        public string BinaryStringToString(string input)
        {
            int count = 0;
            string result = string.Empty;

            while (count < input.Length)
            {
                string bits = input.Substring(count, 8);
                int ascii = Convert.ToInt32(bits, 2);
                result += (char)ascii;
                count += 8;
            }
            return result;
        }
    }
}
