using ClassroomManager.lib;
using ClassroomManager.repositories;
using ClassroomManager.models;

namespace ClassroomManager.usecases
{
  public class CreateEquipmentUseCase(IEquipmentsRepository equipmentsRepository)
  {
    private readonly IEquipmentsRepository _equipmentsRepository = equipmentsRepository;

    public async Task<Equipment> Execute(Equipment data)
    {
      Equipment equipmentWithSameModel = _equipmentsRepository.FindByModel(data.Model);

      if (equipmentWithSameModel != null)
      {
        throw new Exception("Equipamento já existe!");
      }

      Equipment equipment = await _equipmentsRepository.Create(new(data.Name, data.Model, data.Brand, data.Description, data.Quantity, data.Status));

      return equipment;
    }
  }
}