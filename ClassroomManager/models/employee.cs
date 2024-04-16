using ClassroomManager.models.interfaces;

namespace ClassroomManager.models
{
    public class Employee(string id, string name, int? telephone, string password, int enroll, ROLE role) : IEmployee
  {
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public int? Telephone { get; set; } = telephone;
    public string Password { get; set; } = password;
    public int Enroll { get; set; } = enroll;
    public ROLE Role { get; set; } = role;
  }
}