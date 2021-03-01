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
            return fromBinary.BinaryStringToString(BinaryInput);
        }

        public void Dispose()
        {
            fromBinary = null;
            toBinary = null;
        }

        public string StringToBinary(string input)
        {
            return toBinary.StringToBinary(input);
        }
    }
}
