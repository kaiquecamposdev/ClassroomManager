using ClassroomManager.repositories.inMemory;

namespace ClassroomManager.repositories
{
  public interface IEmployeeRepository
  {
    int Id { get; set; }
    string Name { get; set; }
    string Telephone { get; set; }
    string Password { get; set; }
    int Enroll { get; set; }
    ROLE Role { get; set; }
  }
}