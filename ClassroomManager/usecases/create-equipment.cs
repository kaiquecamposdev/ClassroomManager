using ClassroomManager.models;
using ClassroomManager.repositories;

namespace ClassroomManager.usecases
{
  public class CreateEquipmentUseCase(IEquipmentsRepository equipmentsRepository)
  {
    private readonly IEquipmentsRepository _equipmentsRepository = equipmentsRepository;

    public Equipment Execute(Equipment data)
    {
      Equipment equipment = _equipmentsRepository.Create(new(Guid.NewGuid().ToString(), data.Name, data.Model, data.Brand, data.Quantity, data.Status));

      return equipment;
    }
  }
}