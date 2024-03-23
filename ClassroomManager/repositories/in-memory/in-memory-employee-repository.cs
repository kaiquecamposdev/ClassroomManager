using System;
using System.Runtime.InteropServices;

namespace ClassroomManager.repositories.inMemory
{
  public enum ROLE
  {
    ADMIN,
    TEACHER,
    COORDINATOR,
  }
  internal class InMemoryEmployeeRepository : IEmployeeRepository
  {
    public InMemoryEmployeeRepository() { }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Telephone { get; set; }
    public string Password { get; set; }
    public int Enroll { get; set; }
    public ROLE Role { get; set; }

    public InMemoryEmployeeRepository(int id, string name, string telephone, string password, int enroll, ROLE role)
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