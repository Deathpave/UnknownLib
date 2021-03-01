namespace UnknownLib.Managers.Interfaces
{
    internal interface IEncryption
    {
        string EncryptString(string input, string password);
        string EncryptString(string input, string password, int itterations);
    }
}
