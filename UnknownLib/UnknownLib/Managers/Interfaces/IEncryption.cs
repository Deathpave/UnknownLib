namespace UnknownLib.Managers.Interfaces
{
    public interface IEncryption
    {
        string EncryptString(string input, string password);
        string EncryptString(string input, string password, int itterations);
    }
}
