using ClassroomManager.repositories.models;

namespace ClassroomManager.repositories.inMemory
{
  public class Schedule(int id, string description, DateTime dateStart, DateTime dateEnd, int employeeId, Employee employee, int equipmentId, Equipment equipment)
  {
    public int Id { get; set; } = id;
    public string Description { get; set; } = description;
    public DateTime DateStart { get; set; } = dateStart;
    public DateTime DateEnd { get; set; } = dateEnd;
    public int EmployeeId { get; set; } = employeeId;
    public Employee Employee { get; set; } = employee;
    public int EquipmentId { get; set; } = equipmentId;
    public Equipment Equipment { get; set; } = equipment;
  }
}
