using ClassroomManager.repositories.inMemory;
using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeRegisterEmployeeUseCase
  {
    public static RegisterEmployeeUseCase Create()
    {
      JsonEmployeesRepository employeesRepository = new();
      RegisterEmployeeUseCase useCase = new(employeesRepository);

      return useCase;
    }
  }
}
