using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassroomManager.models
{
  public enum STATUS
  {
    AVAILABLE,
    RESERVED,
    BORROWED,
  }
  internal class Equipment
  {
    public Equipment() { }
    public int Id { get; set; } = RandomNumberGenerator.GetInt32(20);
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Photo { get; set; }
    public int Quantity { get; set; }
    public STATUS Status { get; set; }

    public Equipment(int id, string name, string description, string brand, string model, string photo, int quantity, STATUS status)
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
