using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Managers.Interfaces
{
    public interface IBinary
    {
        string BinaryStringToString(string BinaryInput);
        string StringToBinary(string input);
    }
}
