using System;
using System.Collections.Generic;
using UnknownLib.Files;

namespace UnknownLib.Managers
{
    public class FileManager : IDisposable
    {
        private FromTxt fromTxt = new FromTxt();
        private ToTxt toTxt = new ToTxt();
        private FromCsv fromCsv = new FromCsv();
        private ToCsv toCsv = new ToCsv();
        private FileFinder fileFinder = new FileFinder();

        public List<string> GetMapping()
        {
            return fileFinder.GetMapping();
        }

        /// <summary>
        /// Call GetMapping() after to get results.
        /// GetMapping returns null, while mapping process is running.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="startFolderPath"></param>
        public void FindFile(string filename, string startFolderPath)
        {
            fileFinder.FindFile(filename, startFolderPath);
        }

        /// <summary>
        /// Call GetMapping() after to get results.
        /// GetMapping returns null, while mapping process is running.
        /// </summary>
        /// <param name="startingFolder"></param>
        public void RecursiveMapping(string startingFolder)
        {
            fileFinder.RecursiveMapping(startingFolder);
        }

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
            fileFinder = null;
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

        public bool StringToCsv(string input)
        {
            return toCsv.StringToCsv(input);
        }

        public bool StringsToCsv(string[] input)
        {
            return toCsv.StringsToCsv(input);
        }

        public string StringFromCsv()
        {
            return fromCsv.ToString();
        }

        public List<string[]> ListStringArraysFromCsv()
        {
            return fromCsv.ListStringArraysFromCsv();
        }
    }
}
