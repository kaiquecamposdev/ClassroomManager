using ClassroomManager.repositories.models;
using ClassroomManager.Promptio.Controllers.Employees;
using Sharprompt;
using ClassroomManager.repositories;
using ClassroomManager.usecases;
using ClassroomManager.models;
using ClassroomManager.lib;

namespace ClassroomManager.Promptio.Controllers.Employees
{
    public class Authenticate()
    {
      private readonly SharpromptProvider _inputProvider = new();

      public Employee Execute()
      {
        var enroll = _inputProvider.GetIntInput("Digite o número de matrícula do funcionário:");
        var password = _inputProvider.GetPasswordInput("Digite a senha do funcionário:");

        AuthenticateEmployee authenticateEmployeeRequest = new(enroll, password);
        AuthenticateEmployee authEmployee = new(enroll: authenticateEmployeeRequest.Enroll, password: authenticateEmployeeRequest.Password);

        AuthenticateUseCase employeeUseCase = MakeAuthenticateEmployeeUseCase.Create();
        Employee employee = employeeUseCase.Execute(authEmployee);

        return employee;
      }
    }
}