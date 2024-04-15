using ClassroomManager.models;
using ClassroomManager.repositories;
using ClassroomManager.usecases.errors;
namespace ClassroomManager.usecases
{
  public class ConsultReportUseCase(IReportsRepository reportsRepository)
  {
    private readonly IReportsRepository _reportsRepository = reportsRepository;
    public List<Report> Execute(string employeeId)
    {
      List<Report> reports = _reportsRepository.GetByEmployeeId(employeeId);

      if (reports.Count == 0)
      {
        throw new ResourceNotFoundError();
      }

      return reports;
    }
  }
}
