namespace UnknownLib.Managers.Interfaces
{
    internal interface IDecryption
    {
        string DecryptString(string encrypted, string password);
        string DecryptString(string encrypted, string password, int itterations);
    }
}
