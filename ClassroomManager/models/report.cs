namespace ClassroomManager.models
{
  public class Report(int id, string description, DateTime date, int employeeId, Employee employee, int equipmentId, Equipment equipment)
  {
    public int Id { get; set; } = id;
    public string Description { get; set; } = description;
    public DateTime Date { get; set; } = date;
    public int EmployeeId { get; set; } = employeeId;
    public Employee Employee { get; set; } = employee;
    public int EquipmentId { get; set; } = equipmentId;
    public Equipment Equipment { get; set; } = equipment;
  }
}
