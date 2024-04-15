using ClassroomManager.models;

namespace ClassroomManager.repositories
{
  public interface IReportsRepository
  {
    public Report Create(Report report);
    public List<Report> GetByEmployeeId(string employeeId);
  }
}
