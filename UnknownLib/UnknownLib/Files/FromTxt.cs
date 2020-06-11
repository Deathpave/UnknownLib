using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Files
{
    class FromTxt
    {
        public string StringFromTxt(string path)
        {
            // reads file into result string
            string result = File.ReadAllText(path);

            // returns result string
            return result;
        }

        public string[] StringsFromTxt(string path)
        {
            // reads file into result array
            string[] result = File.ReadAllLines(path);

            // returns result array
            return result;
        }

        public char[] CharsFromTxt(string path)
        {
            // reads file into string text
            string text = File.ReadAllText(path);

            // converts string text to result char array
            char[] result = text.ToCharArray();

            // returns result char array
            return result;
        }
    }
}
