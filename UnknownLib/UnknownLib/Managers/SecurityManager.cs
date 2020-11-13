using UnknownLib.Decryption;
using UnknownLib.Encryption;
using UnknownLib.Managers.Interfaces;

namespace UnknownLib.Managers
{
    public class SecurityManager : IEncryption, IDecryption
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

        public string EncryptString(string input, string password)
        {
            return encrypt.EncryptString(input, password);
        }

        public string EncryptString(string input, string password, int itterations)
        {
            return encrypt.EncryptString(input, password, itterations);
        }
    }
}
