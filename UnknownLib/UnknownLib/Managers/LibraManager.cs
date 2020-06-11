using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnknownLib.Binary;
using UnknownLib.Decryption;
using UnknownLib.Files;
using UnknownLib.Encryption;

namespace UnknownLib.Managers
{
    /// <summary>
    /// Manager class to handle the methods in the library
    /// </summary>
    public class LibraManager
    {
        // classes with methods
        #region Binary
        FromBinary fromBinary = new FromBinary();
        ToBinary toBinary = new ToBinary();
        #endregion
        #region Decryption
        Decrypt decrypt = new Decrypt();
        #endregion
        #region Encryption
        Encrypt encrypt = new Encrypt();
        #endregion
        #region Files Folder
        FromTxt txt = new FromTxt();
        FromCsv csv = new FromCsv();
        ToCsv toCsv = new ToCsv();
        ToTxt toTxt = new ToTxt();
        #endregion

        #region Files Methods
        public string StringFromTxt(string path)
        {
            return txt.StringFromTxt(path);
        }

        public string[] StringsFromTxt(string path)
        {
            return txt.StringsFromTxt(path);
        }

        public char[] CharsFromTxt(string path)
        {
            return txt.CharsFromTxt(path);
        }

        public bool StringToTxt(string path, string input)
        {
            return toTxt.StringToTxt(path, input);
        }
        #endregion

    }
}
