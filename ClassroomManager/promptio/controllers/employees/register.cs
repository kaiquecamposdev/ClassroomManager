using Sharprompt;
using ClassroomManager.usecases.factories;
using ClassroomManager.repositories;
using System.Data;
using ClassroomManager.lib;
using ClassroomManager.models.interfaces;
using ClassroomManager.usecases;

namespace ClassroomManager.promptio.controllers.employees
{
  public class Register
  {
    private readonly SharpromptProvider _inputProvider = new();

    public void Execute()
    {
      string name = _inputProvider.GetStringInput("Digite o nome do funcionário:");
      int enroll = _inputProvider.GetIntInput("Digite o número de matrícula do funcionário:");
      string password = _inputProvider.GetPasswordInput("Digite a senha do funcionário:");
      bool acceptInsertTelephone = _inputProvider.GetBoolInput("Deseja inserir o telefone do funcionário?");
      int? telephone = acceptInsertTelephone ? _inputProvider.GetIntInput("Digite o telefone do funcionário:") : null;
      string roleString = _inputProvider.Select("Selecione o cargo do funcionário:", new[] { "Administrador", "Professor", "Coordenador" });
      ROLE role = roleString == "Professor" ? ROLE.TEACHER : roleString == "Administrador" ? ROLE.ADMIN : ROLE.COORDINATOR;

      try
      {
        Employee employee = new(name, telephone, password, enroll, role);

        RegisterEmployeeUseCase employeeUseCase = MakeRegisterEmployeeUseCase.Create();
        employeeUseCase.Execute(employee);

        Console.WriteLine("Usuário cadastrado com sucesso!");
      } catch (Exception e)
      {
        throw new Exception("Funcionário não cadastrado!", e);
      }
    }
  }
}
