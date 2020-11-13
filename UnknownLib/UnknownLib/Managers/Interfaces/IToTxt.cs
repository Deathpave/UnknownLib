namespace UnknownLib.Managers.Interfaces
{
    public interface IToTxt
    {
        bool StringToTxt(string input);
        bool AppendStringToTxt(string input);
        bool StringsToTxt(string[] input);
        bool AppendStringsToTxt(string[] input);
        bool CharToTxt(char input);
        bool AppendCharToTxt(char input);
        bool CharsToTxt(char[] input);
        bool AppendCharsToTxt(char[] input);
    }
}