using System.ComponentModel.DataAnnotations;

namespace ClassroomManager.models.interfaces
{
  public enum ROLE
  {
    ADMIN,
    TEACHER,
    COORDINATOR,
  }
  internal interface IEmployee
  {
    string Id { get; }
    [Required(ErrorMessage = "Nome é requirido")]
    string Name { get; set; }
    int? Telephone { get; set; }
    [Range(8, 16, ErrorMessage = "Senha é requirido")]
    string Password { get; set; }
    [Required(ErrorMessage = "Número de matrícula é requirido")]
    int Enroll { get; set; }
    ROLE Role { get; set; }
  }
}
