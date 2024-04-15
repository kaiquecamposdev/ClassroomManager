namespace ClassroomManager.models
{
  public class Report(string employeeId, string equipmentId)
  {
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string EmployeeId { get; set; } = employeeId;
    public string EquipmentId { get; set; } = equipmentId;
    public DateTime CreatedAt { get; private set; } = new();
  }
}
