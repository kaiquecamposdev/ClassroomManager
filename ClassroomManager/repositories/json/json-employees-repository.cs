using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using Newtonsoft.Json;

namespace ClassroomManager.repositories.json
{
    public class JsonEmployeesRepository : IEmployeesRepository
  {
    private List<Employee> items;
    private readonly BcryptProvider _bcryptProvider = new();
    private readonly string _filePath;

    public JsonEmployeesRepository()
    {
      string projectRootDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, ".."));
      string dbDirectoryPath = Path.Combine(projectRootDirectory, "db");
      Directory.CreateDirectory(dbDirectoryPath);
      _filePath = Path.Combine(dbDirectoryPath, "employees.json");
      LoadEmployeesFromFile().Wait();
    }

    public Employee Create(Employee employee)
    {
      items.Add(employee);
      _ = SaveEmployeesToFile(items);

      return employee;
    }

    public Employee FindById(string id)
    {
      return items.Find(employee => employee.Id == id);
    }

    public Employee FindByEnroll(int enroll)
    {
      return items.Find(employee => employee.Enroll == enroll);
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
        items = new List<Employee>()
        {
          new("Admin", 123456789, password: _bcryptProvider.HashPassword("admin"), 123456, ROLE.ADMIN)
        };
      }
    }

    private async Task SaveEmployeesToFile(List<Employee> items)
    {
      string json = JsonConvert.SerializeObject(items, Formatting.Indented);
      await File.WriteAllTextAsync(_filePath, json);
    }
  }
}
