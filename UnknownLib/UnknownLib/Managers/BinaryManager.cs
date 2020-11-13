using UnknownLib.Binary;
using UnknownLib.Managers.Interfaces;

namespace UnknownLib.Managers
{
    public class BinaryManager : IBinary
    {
        FromBinary fromBinary = new FromBinary();
        ToBinary toBinary = new ToBinary();
        public string BinaryStringToString(string BinaryInput)
        {
            return fromBinary.BinaryStringToString(BinaryInput);
        }

        public string StringToBinary(string input)
        {
            return toBinary.StringToBinary(input);
        }
    }
}
