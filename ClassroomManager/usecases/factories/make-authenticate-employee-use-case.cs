
using ClassroomManager.repositories.inMemory;
using ClassroomManager.usecases;

namespace ClassroomManager.repositories
{
  public static class MakeAuthenticateEmployeeUseCase
  {
    public static AuthenticateUseCase Create()
    {
      InMemoryEmployeesRepository employeesRepository = new();
      AuthenticateUseCase useCase = new(employeesRepository);

      return useCase;
    }
   }
}
