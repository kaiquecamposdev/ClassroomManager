namespace ClassroomManager.models
{
  public class AuthenticateEmployee(int enroll, string password) : IAuthenticateEmployee
  {
    public int Enroll { get; set; } = enroll;
    public string Password { get; set; } = password;
  }
}
