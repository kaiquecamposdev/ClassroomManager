using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeRequestEquipmentsUseCase
  {
    public static RequestEquipmentsUseCase Create()
    {
      JsonEquipmentsRepository employeesRepository = new();
      RequestEquipmentsUseCase useCase = new(employeesRepository);
      
      return useCase;
    }
  }
}
