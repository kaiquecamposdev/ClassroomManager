using ClassroomManager.repositories.inMemory;

namespace ClassroomManager.usecases.factories
{
  public class MakeRegisterEmployeeUseCase
  {
    public static RegisterEmployeeUseCase Create()
    {
      InMemoryEmployeesRepository employeesRepository = new();
      RegisterEmployeeUseCase useCase = new(employeesRepository);

      return useCase;
    }
  }
}
