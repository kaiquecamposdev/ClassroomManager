using ClassroomManager.models.interfaces;

namespace ClassroomManager.models
{
    public class Equipment(string id, string name, string model, string brand, int quantity, STATUS status) : IEquipment
  {
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Model { get; set; } = model;
    public string Brand { get; set; } = brand;
    public int Quantity { get; set; } = quantity;
    public STATUS Status { get; set; } = status;
  }
}
