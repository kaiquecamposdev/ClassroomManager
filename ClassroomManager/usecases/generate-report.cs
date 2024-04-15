using ClassroomManager.models;
using ClassroomManager.repositories;
using ClassroomManager.usecases.errors;

namespace ClassroomManager.usecases
{
  public class GenerateReportUseCase(IReportsRepository reportsRepository, IEquipmentsRepository equipmentsRepository)
  {
    private readonly IReportsRepository _reportRepository = reportsRepository;
    private readonly IEquipmentsRepository _equipmentRepository = equipmentsRepository;

    public Report Execute(Report data)
    {
      Equipment equipment = _equipmentRepository.FindById(id: data.EquipmentId);

      if (equipment == null)
      {
        throw new ResourceNotFoundError();
      }

      Report report = _reportRepository.Create(new(data.EmployeeId, data.EquipmentId));

      return report;
    }
  }
}
