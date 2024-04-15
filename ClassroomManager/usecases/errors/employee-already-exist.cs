namespace ClassroomManager.usecases.errors
{
  public class EmployeeAlreadyExist : Exception
  {
    public EmployeeAlreadyExist() : base("Número de matrícula já existe.")
    {
    }
  }
}
