using System;
using UnknownLib.Binary;

namespace UnknownLib.Managers
{
    public class BinaryManager : IDisposable
    {
        FromBinary fromBinary = new FromBinary();
        ToBinary toBinary = new ToBinary();
        public string BinaryStringToString(string BinaryInput)
        {
            if (fromBinary.BinaryStringToString(BinaryInput) != null && fromBinary.BinaryStringToString(BinaryInput) != string.Empty)
            {
                return fromBinary.BinaryStringToString(BinaryInput);
            }
            else
            {
                return "Something went wrong converting binary to string";
            }
        }

        public void Dispose()
        {
            fromBinary = null;
            toBinary = null;
        }

        public string StringToBinary(string input)
        {
            if (toBinary.StringToBinary(input) != null && toBinary.StringToBinary(input) != string.Empty)
            {
                return toBinary.StringToBinary(input);
            }
            else
            {
                return "Something went wrong converting string to binary";
            }
        }
    }
}
