using System;

namespace ClassroomManager.models
{
  public enum ROLE
  {
    ADMIN,
    TEACHER,
    COORDINATOR,
  }
  internal class Employee
  {
    public Employee() { }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Telephone { get; set; }
    public string Password { get; set; }
    public int Enroll { get; set; }
    public ROLE Role { get; set; }

    public Employee(int id, string name, string telephone, string password, int enroll, ROLE role)
    {
      this.Id = id;
      this.Name = name;
      this.Telephone = telephone;
      this.Password = password;
      this.Enroll = enroll;
      this.Role = role;
    }
  }
}