using ClassroomManager.models.interfaces;
using ClassroomManager.models;
using Newtonsoft.Json;

namespace ClassroomManager.repositories.json
{
  public class JsonReportsRepository : IReportsRepository
  {
    private List<Report> items = [];
    private readonly string _filePath;

    public JsonReportsRepository()
    {
      string projectRootDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, ".."));
      string dbDirectoryPath = Path.Combine(projectRootDirectory, "db");
      Directory.CreateDirectory(dbDirectoryPath);
      _filePath = Path.Combine(dbDirectoryPath, "reports.json");

      LoadReportsFromFile().Wait();
    }

    public Report Create(Report report)
    {
      items.Add(report);
      _ = SaveReportsToFile(items);

      return report;
    }

    public List<Report> GetByEmployeeId(string employeeId)
    {
      return items.Where(item => item.EmployeeId == employeeId).ToList();
    }

    private async Task LoadReportsFromFile()
    {
      if (File.Exists(_filePath))
      {
        string json = await File.ReadAllTextAsync(_filePath);
        items = JsonConvert.DeserializeObject<List<Report>>(json);
      }
      else
      {
        items = new List<Report>();
      }
    }

    private async Task SaveReportsToFile(List<Report> items)
    {
      string json = JsonConvert.SerializeObject(items, Formatting.Indented);
      await File.WriteAllTextAsync(_filePath, json);
    }
  }
}
