using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeRegisterUseCase
  {
    public static RegisterUseCase Create()
    {
      JsonEmployeesRepository employeesRepository = new();
      RegisterUseCase useCase = new(employeesRepository);

      return useCase;
    }
  }
}
