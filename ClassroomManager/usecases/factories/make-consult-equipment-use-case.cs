using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeConsultEquipmentUseCase
  {
    public static ConsultEquipmentUseCase Create()
    {
      JsonEquipmentsRepository equipmentsRepository = new();
      ConsultEquipmentUseCase useCase = new(equipmentsRepository);

      return useCase;
    }
  }
}
