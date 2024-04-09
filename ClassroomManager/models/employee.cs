using ClassroomManager.models.interfaces;
using System.ComponentModel.DataAnnotations;

namespace ClassroomManager.models
{
  public class Employee(string name, int? telephone, string password, int enroll, ROLE role) : IEmployee
  {
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    [Required(ErrorMessage = "Nome é requirido")]
    public string Name { get; set; } = name;
    public int? Telephone { get; set; } = telephone;
    [Range(8, 16, ErrorMessage = "Senha é requirido")]
    public string Password { get; set; } = password;
    [Required(ErrorMessage = "Número de matrícula é requirido")]
    public int Enroll { get; set; } = enroll;
    public ROLE Role { get; set; } = role;
  }
}