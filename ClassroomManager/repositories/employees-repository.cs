using ClassroomManager.models;

namespace ClassroomManager.repositories
{
  public interface IEmployeesRepository
  {
    public Task<Employee> Create(Employee employee);
    public Task Remove(string id);
    public Employee FindById(string id);
    public Employee FindByEnroll(int enroll);
  }
}
