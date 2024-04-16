namespace ClassroomManager.models
{
  public class Report(string id, string employeeId, string equipmentId)
  {
    public string Id { get; set; } = id;
    public string EmployeeId { get; set; } = employeeId;
    public string EquipmentId { get; set; } = equipmentId;
    public DateTime CreatedAt { get; set; } = new();
  }
}
