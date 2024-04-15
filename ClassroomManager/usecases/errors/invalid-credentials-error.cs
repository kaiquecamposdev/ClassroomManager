namespace ClassroomManager.usecases.errors
{
  public class InvalidCredentialsError : Exception
  {
    public InvalidCredentialsError() : base("Credenciais inválidas.")
    {
    }
  }
}
