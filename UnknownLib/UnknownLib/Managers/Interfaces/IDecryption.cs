namespace UnknownLib.Managers.Interfaces
{
    public interface IDecryption
    {
        string DecryptString(string encrypted, string password);
        string DecryptString(string encrypted, string password, int itterations);
    }
}
