using System;
using UnknownLib.Decryption;
using UnknownLib.Encryption;
using UnknownLib.Hashing;
using UnknownLib.Managers.Interfaces;

namespace UnknownLib.Managers
{
    public class SecurityManager : IEncryption, IDecryption, IDisposable
    {
        private Encrypt encrypt = new Encrypt();
        private Decrypt decrypt = new Decrypt();
        public string DecryptString(string encrypted, string password)
        {
            return decrypt.DecryptString(encrypted, password);
        }

        public string DecryptString(string encrypted, string password, int itterations)
        {
            return decrypt.DecryptString(encrypted, password, itterations);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string EncryptString(string input, string password)
        {
            return encrypt.EncryptString(input, password);
        }

        public string EncryptString(string input, string password, int itterations)
        {
            return encrypt.EncryptString(input, password, itterations);
        }

        // hashing overloads for different inputs
        // string input, byte input, with and without password
        public void Hash(HashType type, string input)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    break;
                case HashType.Sha1Hash:
                    break;
                case HashType.Sha2Hash:
                    break;
                case HashType.Sha3Hash:
                    break;
                case HashType.Sha5Hash:
                    break;
            }
        }

        public void Hash(HashType type, string input, string password)
        {
            switch (type)
            {
                case HashType.HmacSha1:
                    break;
                case HashType.HmacSha2:
                    break;
            }
        }

        public void Hash(HashType type, byte[] input)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    break;
                case HashType.Sha1Hash:
                    break;
                case HashType.Sha2Hash:
                    break;
                case HashType.Sha3Hash:
                    break;
                case HashType.Sha5Hash:
                    break;
                case HashType.HmacSha1:
                    break;
                case HashType.HmacSha2:
                    break;
            }
        }

        public void Hash(HashType type, byte[] input, byte[] password)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    break;
                case HashType.Sha1Hash:
                    break;
                case HashType.Sha2Hash:
                    break;
                case HashType.Sha3Hash:
                    break;
                case HashType.Sha5Hash:
                    break;
                case HashType.HmacSha1:
                    break;
                case HashType.HmacSha2:
                    break;
            }
        }
    }
}
