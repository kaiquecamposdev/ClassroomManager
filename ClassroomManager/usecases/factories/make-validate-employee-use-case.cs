
namespace ClassroomManager.repositories
{
  public static class MakeValidateEmployeeUseCase
  {
    public static ValidateEmployeeUseCase Create()
    { 
      var employeesRepository = new InMemoryEmployeesRepository();
      var useCase = new ValidateEmployeeUseCase(employeesRepository);
      return useCase;
    }
   }
}
