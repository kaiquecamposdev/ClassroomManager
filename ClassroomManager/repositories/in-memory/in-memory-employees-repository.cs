using ClassroomManager.models;

namespace ClassroomManager.repositories.inMemory
{
  public class InMemoryEmployeesRepository : IEmployeesRepository
  {
    private readonly List<Employee> items = [];

    public Employee Create(Employee employee)
    {
      this.items.Add(employee ?? throw new Exception("Funcionário não criado!"));

      return employee;
    }

    public Employee FindByEnroll(int enroll)
    {
      var employee = this.items.Find((employee) => employee.Enroll == enroll);

      return employee ?? throw new Exception("Funcionário não encontrado!");
    }

    public Employee FindByEnrollAndPassword(int enroll, string password)
    {
      var employee = this.items.Find((employee) => employee.Enroll == enroll && employee.Password == password);

      return employee ?? throw new Exception("Funcionário não encontrado!");
    }

    public Employee FindById(string id)
    {
      throw new NotImplementedException();
    }

    public void Remove(string id)
    {
      throw new NotImplementedException();
    }
  }
}
