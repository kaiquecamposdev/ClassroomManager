using ClassroomManager.repositories.inMemory;

namespace ClassroomManager.usecases.factories
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
