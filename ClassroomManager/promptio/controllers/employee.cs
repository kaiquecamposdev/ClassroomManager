using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.usecases;
using ClassroomManager.usecases.errors;
using ClassroomManager.usecases.factories;

namespace ClassroomManager.promptio.controllers
{
  public class EmployeeController
  {
    private readonly SharpromptProvider _prompt = new();

    public void Register()
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
          Register();
          break;
      }

      try
      {
        Employee employee = new(Guid.NewGuid().ToString(), name, telephone, password, enroll, role);

        RegisterUseCase employeeUseCase = MakeRegisterUseCase.Create();
        employeeUseCase.Execute(employee);

        Console.Clear();
        Console.WriteLine("Funcionário cadastrado com sucesso!");
        Task.Delay(500).Wait();

        return;
      } 
      catch (InvalidCredentialsError err)
      {
        if (err is InvalidCredentialsError)
        {
          Console.WriteLine(err.Message);
        }

        throw;
      }
    }

    public Employee Authenticate()
    {
      Console.Clear();
      Console.WriteLine("Autenticação de Funcionários\n");

      int enroll = _prompt.GetIntInput("Número de matrícula");
      string password = _prompt.GetPasswordInput("Senha");

      try
      {
        AuthenticateEmployee authenticateEmployeeRequest = new(enroll, password);

        AuthenticateUseCase employeeUseCase = MakeAuthenticateEmployeeUseCase.Create();
        Employee employee = employeeUseCase.Execute(authenticateEmployeeRequest);

        return employee;
      }
      catch (InvalidCredentialsError err)
      {
        if (err is InvalidCredentialsError)
        {
          Console.WriteLine(err.Message);
        }

        throw;
      }
    }
  }
}
