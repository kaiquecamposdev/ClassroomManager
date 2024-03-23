using ClassroomManager.repositories;

namespace ClassroomManager.repositories.inMemory
{
  internal class InMemoryReportRepository : IReportRepository
  {
    public InMemoryReportRepository() { }
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int EmployeeId { get; set; }
    public IEmployeeRepository Employee { get; set; }
    public int EquipmentId { get; set; }
    public IEquipmentRepository Equipment { get; set; }

    public InMemoryReportRepository(int id, string description, DateTime date, int employeeId, Employee employee, int equipmentId, Equipment equipment)
    {
      this.Id = id;
      this.Description = description;
      this.Date = date;
      this.EmployeeId = employeeId;
      this.Employee = employee;
      this.EquipmentId = equipmentId;
      this.Equipment = equipment;
    }
  }
}
