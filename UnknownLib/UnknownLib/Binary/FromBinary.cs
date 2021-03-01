using System;

namespace UnknownLib.Binary
{
    internal class FromBinary
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
