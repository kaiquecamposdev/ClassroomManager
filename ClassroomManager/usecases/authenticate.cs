using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.repositories;

namespace ClassroomManager.usecases
{
  public class AuthenticateUseCase(IEmployeesRepository employeesRepository)
  {
    public readonly IEmployeesRepository _employeesRepository = employeesRepository;
    public readonly BcryptProvider _bcryptProvider = new();

    public Employee Execute(IAuthenticateEmployee data)
    {
      Employee employee = _employeesRepository.FindByEnroll(data.Enroll);

      if (employee == null)
      {
        throw new Exception("Credenciais inválidas.");
      }

      bool passwordMatch = _bcryptProvider.VerifyPassword(data.Password, employee.Password);

      if (!passwordMatch)
      {
        throw new Exception("Credenciais inválidas.");
      }

      return employee;
    }
  }
}