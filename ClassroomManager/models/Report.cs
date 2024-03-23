using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManager.models
{
  internal class Report
  {
    public Report() { }
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public int EquipmentId { get; set; }
    public Equipment Equipment { get; set; }

    public Report(int id, string description, DateTime date, int employeeId, Employee employee, int equipmentId, Equipment equipment)
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
