using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnknownLib.Encryption
{
    class Encrypt
    {
        // salt byte array
        byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        // rijndael class
        RijndaelManaged rijndael = new RijndaelManaged();
        public string EncryptString(string input, string password)
        {

            // derived bytes to make key and vector
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt);

            // key gets set
            rijndael.Key = rfc.GetBytes(32);

            // vector gets set
            rijndael.IV = rfc.GetBytes(16);

            // creates streams to "write" the data
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);

            // gets bytes of the input
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // converts the input bytes to encrypted bytes
            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
            cryptoStream.FlushFinalBlock();
            cryptoStream.Close();

            // converts the encryted bytes back to string
            string result = Convert.ToBase64String(memoryStream.ToArray());
            return result;
        }
    }
}
