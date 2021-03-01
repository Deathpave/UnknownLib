using System;
using System.Text;

namespace UnknownLib.Binary
{
    internal class ToBinary
    {
        public string StringToBinary(string input)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            string result = string.Empty;

            foreach (byte b in bytes)
            {
                result += Convert.ToString(b, 2).PadLeft(8, '0');
            }

            return result;
        }
    }
}
