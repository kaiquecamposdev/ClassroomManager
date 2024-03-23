using ClassroomManager.repositories.inMemory;

namespace ClassroomManager.repositories.inMemory
{
  public interface IReportRepository
  {
    int Id { get; set; }
    string Description { get; set; }
    DateTime Date { get; set; }
    int EmployeeId { get; set; }
    IEmployeeRepository Employee { get; set; }
    int EquipmentId { get; set; }
    IEquipmentRepository Equipment { get; set; }
  }
}