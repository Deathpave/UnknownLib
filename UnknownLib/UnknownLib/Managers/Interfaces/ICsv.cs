using System.Collections.Generic;

namespace UnknownLib.Managers.Interfaces
{
    public interface ICsv
    {
        List<string[]> ListStringsFromCsv();
        bool StringsToCsv(string[] input);
    }
}
