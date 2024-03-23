using ClassroomManager.repositories.inMemory;
using System.Security.Cryptography;

namespace ClassroomManager.repositories.inMemory
{
  public interface IScheduleRepository
  {
    int Id { get; set; }
    string Description { get; set; }
    DateTime DateStart { get; set; }
    DateTime DateEnd { get; set; }
    int EmployeeId { get; set; }
    IEmployeeRepository Employee { get; set; }
    int EquipmentId { get; set; }
    IEquipmentRepository Equipment { get; set; }
  }
}