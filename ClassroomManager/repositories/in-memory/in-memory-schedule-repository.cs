using System.Security.Cryptography;

namespace ClassroomManager.repositories.inMemory
{
  internal class InMemoryScheduleRepository : IScheduleRepository
  {
    public int Id { get; set; } = RandomNumberGenerator.GetInt32(20);
    public string Description { get; set; }
    public DateTime DateStart { get; set; } = DateTime.Now;
    public DateTime DateEnd { get; set; }
    public int EmployeeId { get; set; }
    public IEmployeeRepository Employee { get; set; }
    public int EquipmentId { get; set; }
    public IEquipmentRepository Equipment { get; set; }

    public InMemoryScheduleRepository(int id, string description, DateTime dateStart, DateTime dateEnd, int employeeId, Employee employee, int equipmentId, Equipment equipment)
    {
      this.Id = id;
      this.Description = description;
      this.DateStart = dateStart;
      this.DateEnd = dateEnd;
      this.EmployeeId = employeeId;
      this.Employee = employee;
      this.EquipmentId = equipmentId;
      this.Equipment = equipment;
    }
  }
}
