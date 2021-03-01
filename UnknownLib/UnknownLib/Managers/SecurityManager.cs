using System;
using UnknownLib.Decryption;
using UnknownLib.Encryption;
using UnknownLib.Hashing;

namespace UnknownLib.Managers
{
    public class SecurityManager : IDisposable
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
        // needs to return byte or string depending on input
        // if string input => string output
        // if byte input => byte output
        public string Hash(HashType type, string input)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    Md5Hash md5 = new Md5Hash();
                    return md5.Hash(input);
                case HashType.Sha1Hash:
                    Sha1Hash sha1 = new Sha1Hash();
                    return sha1.Hash(input);
                case HashType.Sha2Hash:
                    Sha2Hash sha2 = new Sha2Hash();
                    return sha2.Hash(input);
                case HashType.Sha3Hash:
                    Sha3Hash sha3 = new Sha3Hash();
                    return sha3.Hash(input);
                case HashType.Sha5Hash:
                    Sha5Hash sha5 = new Sha5Hash();
                    return sha5.Hash(input);
                default:
                    return "Cannot hash with this input";
            }
        }

        public string Hash(HashType type, string input, string password)
        {
            switch (type)
            {
                case HashType.HmacSha1:
                    HmacSha1 hmacSha1 = new HmacSha1();
                    return hmacSha1.Hash(input, password);
                case HashType.HmacSha2:
                    break;
                default:
                    return "Cannot hash with these inputs";
            }
            return "Something went wrong during hashing";
        }

        public byte[] Hash(HashType type, byte[] input)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    Md5Hash md5 = new Md5Hash();
                    return md5.Hash(input);
                case HashType.Sha1Hash:
                    Sha1Hash sha1 = new Sha1Hash();
                    return sha1.Hash(input);
                case HashType.Sha2Hash:
                    Sha2Hash sha2 = new Sha2Hash();
                    return sha2.Hash(input);
                case HashType.Sha3Hash:
                    Sha3Hash sha3 = new Sha3Hash();
                    return sha3.Hash(input);
                case HashType.Sha5Hash:
                    Sha5Hash sha5 = new Sha5Hash();
                    return sha5.Hash(input);
                default:
                    return null;
            }
        }

        public byte[] Hash(HashType type, byte[] input, byte[] password)
        {
            switch (type)
            {
                case HashType.HmacSha1:
                    HmacSha1 hmacSha1 = new HmacSha1();
                    return hmacSha1.Hash(input, password);
                case HashType.HmacSha2:
                    break;
                default:
                    return null;
            }
            return null;
        }
    }
}
