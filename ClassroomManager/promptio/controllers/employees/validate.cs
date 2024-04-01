using ClassroomManager.repositories.models;
using ClassroomManager.Promptio.Controllers.Employees;
using Sharprompt;
using ClassroomManager.repositories;

namespace ClassroomManager.Promptio.Controllers.Employees
{
  public class Validate()
  {
    public static string Execute()
    {
      string name = Prompt.Input<string>("Qual o seu nome?");
      string user_role = Prompt.Select<string>("Qual é o seu papel?", new[] { "Professor", "Coordenador" });
      string password = Prompt.Password("Digite a sua senha");
      int enroll = Prompt.Input<int>("Digite o seu número de matrícula:");

      ROLE role = user_role == "Professor" ? ROLE.TEACHER : ROLE.COORDINATOR;

      Employee employee = new(name, null, password, enroll, role);

      var employeeUseCase = makeValidateEmployeeUseCase(employee);
      employeeUseCase.Execute();

      return $"Bem vindo! {user_role} {name}";
    }
  }
}