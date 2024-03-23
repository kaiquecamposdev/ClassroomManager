using ClassroomManager.repositories.inMemory;

namespace ClassroomManager.repositories.inMemory
{
  public interface IEquipmentRepository
  {
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
    string Brand { get; set; }
    string Model { get; set; }
    string Photo { get; set; }
    int Quantity { get; set; }
    STATUS Status { get; set; }
  }
}
