using System.Collections.Generic;

namespace UnknownLib.Managers.Interfaces
{
    internal interface ICsv
    {
        List<string[]> ListStringsFromCsv();
        bool StringsToCsv(string[] input);
    }
}
