using System.Security.Cryptography;

namespace ClassroomManager.repositories.models

{
  public enum STATUS
  {
    AVAILABLE,
    RESERVED,
    BORROWED,
  }
  public class Equipment(int id, string name, string description, string brand, string model, string photo, int quantity, STATUS status)
  {
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public string Brand { get; set; } = brand;
    public string Model { get; set; } = model;
    public string Photo { get; set; } = photo;
    public int Quantity { get; set; } = quantity;
    public STATUS Status { get; set; } = status;
  }
}
