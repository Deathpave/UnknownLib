using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnknownLib.Binary;
using UnknownLib.Decryption;
using UnknownLib.Files;
using UnknownLib.Encryption;
using System.Runtime.InteropServices.WindowsRuntime;

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

        #region Binary
        #region FromBinary
        public string BinaryStringToString(string input)
        {
            return fromBinary.BinaryStringToString(input);
        }
        #endregion
        #region ToBinary
        public string StringToBinary(string input)
        {
            return toBinary.StringToBinary(input);
        }
        #endregion
        #endregion

        #region Decryption
        #region Decrypt

        public string DecryptString(string encrypted, string password)
        {
            return decrypt.DecryptString(encrypted, password);
        }

        #endregion
        #endregion

        #region Encryption
        #region Encrypt

        public string EncryptString(string input, string password)
        {
            return encrypt.EncryptString(input, password);
        }

        #endregion
        #endregion

        #region Files Methods
        #region FromTxt
        public string StringFromTxt()
        {
            return txt.StringFromTxt();
        }

        public string[] StringsFromTxt()
        {
            return txt.StringsFromTxt();
        }

        public char[] CharsFromTxt()
        {
            return txt.CharsFromTxt();
        }
        #endregion
        #region ToTxt
        public bool StringToTxt(string path, string input)
        {
            return toTxt.StringToTxt(path, input);
        }

        public bool AppendStringToTxt(string path, string input)
        {
            return toTxt.AppendStringToTxt(path, input);
        }

        public bool StringsToTxt(string path, string[] input)
        {
            return toTxt.StringsToTxt(path, input);
        }

        public bool AppendStringsToTxt(string path, string[] input)
        {
            return toTxt.AppendStringsToTxt(path, input);
        }

        public bool CharToTxt(string path, char input)
        {
            return toTxt.CharToTxt(path, input);
        }

        public bool AppendCharToTxt(string path, char input)
        {
            return toTxt.AppendCharToTxt(path, input);
        }

        public bool CharsToTxt(string path, char[] input)
        {
            return toTxt.CharsToTxt(path, input);
        }

        public bool AppendCharsToTxt(string path, char[] input)
        {
            return toTxt.AppendCharsToTxt(path, input);
        }
        #endregion
        #endregion

    }
}
