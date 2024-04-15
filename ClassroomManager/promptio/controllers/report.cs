using ClassroomManager.models;
using ClassroomManager.usecases.factories;
using ClassroomManager.usecases;
using ClassroomManager.usecases.errors;

namespace ClassroomManager.promptio.controllers
{
  public class ReportController
  {
    public static void Generate(string employeeId, string equipmentId)
    {
      try
      {
        Report data = new(employeeId, equipmentId);

        GenerateReportUseCase reportUseCase = MakeGenerateReportUseCase.Create();
        reportUseCase.Execute(data);

        return;
      }
      catch (ResourceNotFoundError err)
      {
        if (err is ResourceNotFoundError)
        {
          Console.WriteLine(err.Message);
        }

        throw;
      }
    }
    public static List<Report> GetByEmployeeId(string employeeId)
    {
      try
      {
        ConsultReportUseCase reportUseCase = MakeConsultReportUseCase.Create();
        List<Report> reports = reportUseCase.Execute(employeeId);

        return reports;
      }
      catch (ResourceNotFoundError err)
      {
        if (err is ResourceNotFoundError)
        {
          Console.WriteLine(err.Message);
        }

        throw;
      }
    }
  }
}
