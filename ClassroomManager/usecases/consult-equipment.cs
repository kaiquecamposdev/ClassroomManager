using ClassroomManager.models;
using ClassroomManager.repositories;

namespace ClassroomManager.usecases
{
  public class ConsultEquipmentUseCase(IEquipmentsRepository equipmentsRepository)
  {
    private readonly IEquipmentsRepository _equipmentsRepository = equipmentsRepository;

    public List<Equipment> Execute()
    {
      List<Equipment> equipments = _equipmentsRepository.GetAll();

      if (equipments == null)
      {
        throw new Exception("Conteúdo não encontrado.");
      }

      return equipments;
    }
  }
}