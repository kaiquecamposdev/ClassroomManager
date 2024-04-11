using ClassroomManager.usecases.factories;
using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.usecases;

namespace ClassroomManager.promptio.controllers.employees
{
  public class RegisterEmployee
  {
    private readonly SharpromptProvider _prompt = new();

    public async Task Execute()
    {
      Console.Clear();
      Console.WriteLine("Cadastro de Funcionários\n");

      string name = _prompt.GetStringInput("Nome");
      int enroll = _prompt.GetIntInput("Número de matrícula");
      string password = _prompt.GetPasswordInput("Senha");
      ROLE role = _prompt.Select("Selecione o cargo", new[] { "Professor", "Coordenador" }) == "Professor" ? ROLE.TEACHER : ROLE.COORDINATOR;

      bool acceptInsertTelephone = _prompt.GetBoolInput("Deseja inserir o telefone do funcionário?");
      int? telephone = acceptInsertTelephone ? _prompt.GetIntInput("Telefone") : null;

      string options = _prompt.Select("Deseja finalizar?", new[] { "Finalizar", "Criar Novamente", "Sair" });        

      try
      {
        switch (options)
        {
          case "Finalizar":
            break;
          case "Criar Novamente":
            await Execute();
            break;
          case "Sair":
            return;
        }

        Employee employee = new(name, telephone, password, enroll, role);

        RegisterEmployeeUseCase employeeUseCase = MakeRegisterEmployeeUseCase.Create();
        await employeeUseCase.Execute(employee);

        Console.Clear();
        Console.WriteLine("Usuário cadastrado com sucesso!");

        return;
      } catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
