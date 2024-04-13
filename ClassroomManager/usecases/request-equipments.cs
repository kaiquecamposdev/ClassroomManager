using ClassroomManager.models;
using ClassroomManager.repositories;

namespace ClassroomManager.usecases
{
  public class RequestEquipmentsUseCase(IEquipmentsRepository equipmentsRepository)
  {
    private readonly IEquipmentsRepository _equipmentsRepository = equipmentsRepository;

    public List<Equipment> Execute()
    {
      List<Equipment> equipments = _equipmentsRepository.GetAll();

      return equipments;
    }
  }
}