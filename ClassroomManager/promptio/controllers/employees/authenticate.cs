using ClassroomManager.promptio.controllers.employees;
using ClassroomManager.usecases.factories;
using ClassroomManager.repositories;
using ClassroomManager.usecases;
using ClassroomManager.models;
using ClassroomManager.lib;

namespace ClassroomManager.promptio.controllers.employees
{
    public class Authenticate()
    {
      private readonly SharpromptProvider _prompt = new();

      public Employee Execute()
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

          Console.Clear();
          Console.WriteLine("Usuário autenticado com sucesso!");

          return employee;
        }
        catch (Exception e)
        {
          throw new Exception("Erro no sistema!", e);
        }
      }
    }
}