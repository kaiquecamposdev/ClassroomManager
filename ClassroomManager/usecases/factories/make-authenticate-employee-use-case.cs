using ClassroomManager.repositories.inMemory;
using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public static class MakeAuthenticateEmployeeUseCase
  {
    public static AuthenticateUseCase Create()
    {
      JsonEmployeesRepository employeesRepository = new();
      AuthenticateUseCase useCase = new(employeesRepository);

      return useCase;
    }
   }
}
