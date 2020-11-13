using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Managers.Interfaces
{
    public interface IDecryption
    {
        string DecryptString(string encrypted, string password);
        string DecryptString(string encrypted, string password, int itterations)
       }
}
