using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeGenerateReportUseCase
  {
    public static GenerateReportUseCase Create()
    {
      JsonEquipmentsRepository equipmentsRepository = new();
      JsonReportsRepository reportsRepository = new();

      GenerateReportUseCase useCase = new(reportsRepository, equipmentsRepository);

      return useCase;
    }
  }
}
