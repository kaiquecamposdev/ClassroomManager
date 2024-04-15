namespace ClassroomManager.usecases.errors
{
  public class ResourceNotFoundError : Exception
  {
    public ResourceNotFoundError() : base("Conteúdo não encontrado.")
    {
    }
  }
}
