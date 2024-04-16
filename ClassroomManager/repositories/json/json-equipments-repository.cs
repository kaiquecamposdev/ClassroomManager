using ClassroomManager.models;
using Newtonsoft.Json;

namespace ClassroomManager.repositories.json
{
  public class JsonEquipmentsRepository : IEquipmentsRepository
  {
    private List<Equipment> items = [];
    private readonly string _filePath;

    public JsonEquipmentsRepository()
    {
      string projectRootDirectory = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, ".."));
      string dbDirectoryPath = Path.Combine(projectRootDirectory, "db");
      Directory.CreateDirectory(dbDirectoryPath);
      _filePath = Path.Combine(dbDirectoryPath, "equipments.json");

      LoadEquipmentsFromFile().Wait();
    }

    public Equipment Create(Equipment equipment)
    {
      items.Add(equipment);
      _ = SaveEquipmentsToFile(items);

      return equipment;
    }

    public List<Equipment> GetAll()
    {
      return items;
    }

    public Equipment FindById(string id)
    {
      return items.Find(equipment => equipment.Id == id);
    }

    public Equipment FindByModel(string model)
    {
      return items.Find(equipment => equipment.Model == model);
    }

    private async Task LoadEquipmentsFromFile()
    {
      if (File.Exists(_filePath))
      {
        string json = await File.ReadAllTextAsync(_filePath);
        items = JsonConvert.DeserializeObject<List<Equipment>>(json);
      }
      else
      {
        items = new List<Equipment>();
      }
    }

    private async Task SaveEquipmentsToFile(List<Equipment> items)
    {
      string json = JsonConvert.SerializeObject(items, Formatting.Indented);
      await File.WriteAllTextAsync(_filePath, json);
    }
  }
}
