using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.usecases;
using ClassroomManager.usecases.factories;

namespace ClassroomManager.promptio.controllers.employees
{
  public class Register
  {
    private readonly SharpromptProvider _prompt = new();

    public void Execute()
    {
      Console.Clear();
      Console.WriteLine("Cadastro de Funcionários\n");

      string name = _prompt.GetStringInput("Nome");
      int enroll = _prompt.GetIntInput("Número de matrícula");
      string password = _prompt.GetPasswordInput("Senha");
      ROLE role = _prompt.Select("Selecione o cargo", new[] { "Professor", "Coordenador" }) == "Professor" ? ROLE.TEACHER : ROLE.COORDINATOR;

      bool acceptInsertTelephone = _prompt.GetBoolInput("Deseja inserir o telefone do funcionário?");
      int? telephone = acceptInsertTelephone ? _prompt.GetIntInput("Telefone") : null;

      string options = _prompt.Select("Tem certeza?", new[] { "Sim", "Não" });

      switch (options)
      {
        case "Sim":
          break;
        case "Não":
          Execute();
          break;
      }

      try
      {
        Employee employee = new(name, telephone, password, enroll, role);

        RegisterUseCase employeeUseCase = MakeRegisterUseCase.Create();
        employeeUseCase.Execute(employee);

        Console.Clear();
        Console.WriteLine("Funcionário cadastrado com sucesso!");
        Task.Delay(1000).Wait();

        return;
      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
