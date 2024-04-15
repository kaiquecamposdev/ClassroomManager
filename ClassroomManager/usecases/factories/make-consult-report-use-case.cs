using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases.factories
{
  public class MakeConsultReportUseCase
  {
    public static ConsultReportUseCase Create()
    {
      JsonReportsRepository reportsRepository = new();
      ConsultReportUseCase useCase = new(reportsRepository);

      return useCase;
    }
  }
}
