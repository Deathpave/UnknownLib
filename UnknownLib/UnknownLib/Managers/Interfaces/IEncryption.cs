using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Managers.Interfaces
{
    public interface IEncryption
    {
        string EncryptString(string input, string password);
        string EncryptString(string input, string password, int itterations);
    }
}
