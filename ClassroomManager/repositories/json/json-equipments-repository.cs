using ClassroomManager.models;
using Newtonsoft.Json;

namespace ClassroomManager.repositories.json
{
  public class JsonEquipmentsRepository : IEquipmentsRepository
  {
    private readonly List<Equipment> items = [];
    private readonly string _filePath = "equipments.json";

    public JsonEquipmentsRepository()
    {
      LoadEquipmentsFromFile();
    }

    public async Task<Equipment> Create(Equipment equipment)
    {
      items.Add(equipment);
      await SaveEquipmentsToFile(items);

      return equipment;
    }

    public Equipment FindById(string id)
    {
      return items.Find(equipment => equipment.Id == id);
    }

    public Equipment FindByBrand(string brand)
    {
      return items.Find(equipment => equipment.Brand == brand);
    }

    public Equipment FindByModel(string model)
    {
      return items.Find(equipment => equipment.Model == model);
    }

    public Equipment FindByStatus(STATUS status)
    {
      return items.Find(equipment => equipment.Status.HasFlag(status));
    }

    public async Task Remove(string id)
    {
      int equipmentIndexForRemove = items.FindIndex(equipment => equipment.Id == id);

      items.Remove(items.ElementAt(equipmentIndexForRemove));
      await SaveEquipmentsToFile(items);

      return;
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
