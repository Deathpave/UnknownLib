using System;
using UnknownLib.Files;

namespace UnknownLib.Managers
{
    public class FileManager : IDisposable
    {
        private FromTxt fromTxt = new FromTxt();
        private ToTxt toTxt = new ToTxt();
        private FromCsv fromCsv = new FromCsv();
        private ToCsv toCsv = new ToCsv();

        public bool AppendCharsToTxt(char[] input)
        {
            return toTxt.AppendCharsToTxt(input);
        }

        public bool AppendCharToTxt(char input)
        {
            return toTxt.AppendCharToTxt(input);
        }

        public bool AppendStringsToTxt(string[] input)
        {
            return toTxt.AppendStringsToTxt(input);
        }

        public bool AppendStringToTxt(string input)
        {
            return toTxt.AppendStringToTxt(input);
        }

        public char[] CharsFromTxt()
        {
            return fromTxt.CharsFromTxt();
        }

        public bool CharsToTxt(char[] input)
        {
            return toTxt.CharsToTxt(input);
        }

        public bool CharToTxt(char input)
        {
            return toTxt.CharToTxt(input);
        }

        public void Dispose()
        {
            fromTxt = null;
            toTxt = null;
            fromCsv = null;
            toCsv = null;
        }

        public string StringFromTxt()
        {
            return fromTxt.StringFromTxt();
        }

        public string[] StringsFromTxt()
        {
            return fromTxt.StringsFromTxt();
        }

        public bool StringsToTxt(string[] input)
        {
            return toTxt.StringsToTxt(input);
        }

        public bool StringToTxt(string input)
        {
            return toTxt.StringToTxt(input);
        }
    }
}
