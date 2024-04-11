using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace ClassroomManager.repositories.json
{
  public class JsonEmployeesRepository : IEmployeesRepository
  {
    private List<Employee> items;
    private readonly BcryptProvider _bcryptProvider = new();
    private readonly string _filePath = "employees.json";

    public JsonEmployeesRepository()
    {
      items = new List<Employee>()
      {
        new Employee("Admin", 123456789, password: _bcryptProvider.HashPassword("admin"), 123456, ROLE.ADMIN)
      };
    }

    public async Task<Employee> Create(Employee employee)
    {
      items.Add(employee);
      await SaveEmployeesToFile(items);

      return employee;
    }

    public Employee FindById(string id)
    {
      throw new NotImplementedException();
    }

    public Employee FindByEnroll(int enroll)
    {
      return items.Find(employee => employee.Enroll == enroll);
    }

    public async Task Remove(string id)
    {
      int employeeIndexForRemove = items.FindIndex(employee => employee.Id == id);

      items.Remove(items.ElementAt(employeeIndexForRemove));
      await SaveEmployeesToFile(items);

      return;
    }

    private async Task LoadEmployeesFromFile()
    {
      if (File.Exists(_filePath))
      {
        string json = await File.ReadAllTextAsync(_filePath);
        items = JsonConvert.DeserializeObject<List<Employee>>(json);
      }
      else
      {
        items = new List<Employee>();
      }
    }

    private async Task SaveEmployeesToFile(List<Employee> items)
    {
      string json = JsonConvert.SerializeObject(items, Formatting.Indented);
      await File.WriteAllTextAsync(_filePath, json);
    }
  }
}
