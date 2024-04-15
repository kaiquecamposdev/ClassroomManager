using ClassroomManager.models;

namespace ClassroomManager.repositories
{
  public interface IEmployeesRepository
  {
    public Employee Create(Employee employee);
    public Employee FindById(string id);
    public Employee FindByEnroll(int enroll);
  }
}
