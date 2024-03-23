using System.Security.Cryptography;

namespace ClassroomManager.repositories.inMemory
{
  public enum STATUS
  {
    AVAILABLE,
    RESERVED,
    BORROWED,
  }
  internal class InMemoryEquipmentRepository
  {
    public InMemoryEquipmentRepository() { }
    public int Id { get; set; } = RandomNumberGenerator.GetInt32(20);
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Photo { get; set; }
    public int Quantity { get; set; }
    public STATUS Status { get; set; }

    public InMemoryEquipmentRepository(int id, string name, string description, string brand, string model, string photo, int quantity, STATUS status)
    {
      this.Id = id;
      this.Name = name;
      this.Description = description;
      this.Brand = brand;
      this.Model = model;
      this.Photo = photo;
      this.Quantity = quantity;
      this.Status = status;
    }
  }
}
