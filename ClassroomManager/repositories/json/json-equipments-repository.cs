using ClassroomManager.models;
using Newtonsoft.Json;

namespace ClassroomManager.repositories.json
{
  public class JsonEquipmentsRepository : IEquipmentsRepository
  {
    private List<Equipment> items = [];
    private readonly string _filePath = "equipments.json";

    public JsonEquipmentsRepository()
    {
      _ = LoadEquipmentsFromFile();
    }

    public Equipment Create(Equipment equipment)
    {
      LoadEquipmentsFromFile().Wait();

      items.Add(equipment);
      _ = SaveEquipmentsToFile(items);

      return equipment;
    }

    public List<Equipment> GetAll()
    {
      LoadEquipmentsFromFile().Wait();

      return items;
    }

    public Equipment FindById(string id)
    {
      LoadEquipmentsFromFile().Wait();

      return items.Find(equipment => equipment.Id == id);
    }

    public Equipment FindByBrand(string brand)
    {
      LoadEquipmentsFromFile().Wait();

      return items.Find(equipment => equipment.Brand == brand);
    }

    public Equipment FindByModel(string model)
    {
      LoadEquipmentsFromFile().Wait();

      return items.Find(equipment => equipment.Model == model);
    }

    public Equipment FindByStatus(STATUS status)
    {
      LoadEquipmentsFromFile().Wait();

      return items.Find(equipment => equipment.Status.HasFlag(status));
    }

    public void Remove(string id)
    {
      LoadEquipmentsFromFile().Wait();

      int equipmentIndexForRemove = items.FindIndex(equipment => equipment.Id == id);

      items.Remove(items.ElementAt(equipmentIndexForRemove));
      _ = SaveEquipmentsToFile(items);

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
