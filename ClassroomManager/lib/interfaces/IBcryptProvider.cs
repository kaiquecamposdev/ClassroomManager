namespace ClassroomManager.lib.interfaces
{
    internal interface IBcryptProvider
    {
        string HashPassword(string password);
        bool VerifyPassword(string password, string hash);
    }
}
