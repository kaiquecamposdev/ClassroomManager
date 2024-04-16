using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;

namespace ClassroomManager.repositories.inMemory
{
    public class InMemoryEmployeesRepository : IEmployeesRepository
  {
    private readonly List<Employee> items;
    private readonly BcryptProvider _bcryptProvider = new();
    public InMemoryEmployeesRepository()
    {
      items = new List<Employee>()
        {
            new Employee( Guid.NewGuid().ToString(), "Admin", 123456789, password: _bcryptProvider.HashPassword("admin"), 123456, ROLE.ADMIN)
        };
    }

    public Employee Create(Employee employee)
    {
      items.Add(employee);

      return employee;
    }
    public Employee FindById(string id)
    {
      throw new NotImplementedException();
    }

    public Employee FindByEnroll(int enroll)
    {
      Employee employee = items.Find((employee) => employee.Enroll == enroll);

      return employee;
    }

    public void Remove(string id)
    {
      throw new NotImplementedException();
    }
  }
}
