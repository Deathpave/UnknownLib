using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Managers.Interfaces
{
    public interface ICsv
    {
        List<string[]> ListStringsFromCsv();
        bool StringsToCsv(string[] input);
    }
}
