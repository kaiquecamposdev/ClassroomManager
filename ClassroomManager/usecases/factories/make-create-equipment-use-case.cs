using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeCreateEquipmentUseCase
  {
    public static CreateEquipmentUseCase Create()
    {
      JsonEquipmentsRepository equipmentsRepository = new();
      CreateEquipmentUseCase useCase = new(equipmentsRepository);

      return useCase;
    }
  }
}
