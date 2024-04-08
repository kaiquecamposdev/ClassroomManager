using ClassroomManager.lib.interfaces;

namespace ClassroomManager.lib
{
  public class BcryptProvider : IBcryptProvider
  {
    public string HashPassword(string password)
    {
      return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public bool VerifyPassword(string password, string hash)
    {
      return BCrypt.Net.BCrypt.Verify(password, hash);
    }
  }
}
