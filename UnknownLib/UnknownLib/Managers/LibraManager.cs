﻿using System;
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
        #region Files
        FromTxt txt = new FromTxt();
        ToTxt toTxt = new ToTxt();
        FromCsv csv = new FromCsv();
        ToCsv toCsv = new ToCsv();
        #endregion

        // methods from classes
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

        public string DecryptString(string encrypted, string password, int itterations)
        {
            return decrypt.DecryptString(encrypted, password, itterations);
        }

        #endregion
        #endregion

        #region Encryption
        #region Encrypt

        public string EncryptString(string input, string password)
        {
            return encrypt.EncryptString(input, password);
        }

        public string EncryptString(string input, string password, int itterations)
        {
            return encrypt.EncryptString(input, password, itterations);
        }

        #endregion
        #endregion

        #region Files
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
        #region FromCsv
        public List<string[]> ListStringsFromCsv()
        {
            return csv.ListStringArraysFromCsv();
        }
        #endregion
        #region ToCsv
        public bool StringsToCsv(string[] input)
        {
            return toCsv.StringsToCsv(input);
        }
        #endregion
        #endregion

    }
}
