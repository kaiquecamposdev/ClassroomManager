using ClassroomManager.models;
using ClassroomManager.repositories;
using ClassroomManager.usecases.errors;

namespace ClassroomManager.usecases
{
  public class ConsultEquipmentUseCase(IEquipmentsRepository equipmentsRepository)
  {
    private readonly IEquipmentsRepository _equipmentsRepository = equipmentsRepository;

    public List<Equipment> Execute()
    {
      List<Equipment> equipments = _equipmentsRepository.GetAll();

      if (equipments.Count == 0)
      {
        throw new ResourceNotFoundError();
      }

      return equipments;
    }
  }
}