using ClassroomManager.models;

namespace ClassroomManager.repositories
{
  public interface IEmployeesRepository
  {
    public Employee Create(Employee employee);
    public void Remove(string id);
    public Employee FindById(string id);
    public Employee FindByEnroll(int enroll);
  }
}
