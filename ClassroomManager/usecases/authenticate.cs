using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.repositories;

namespace ClassroomManager.usecases
{
  public class AuthenticateUseCase(IEmployeesRepository employeesRepository)
  {
    public readonly IEmployeesRepository _employeesRepository = employeesRepository;
    public readonly BcryptProvider _bcryptProvider = new();

    public Employee Execute(IAuthenticateEmployee data)
    {
      var employee = _employeesRepository.FindByEnrollAndPassword(data.Enroll, data.Password) ?? throw new Exception("Funcionário não existe!");
      var passwordMatch = _bcryptProvider.VerifyPassword(data.Password, employee.Password);

      if (passwordMatch == false)
      {
        throw new Exception("Credenciais inválidas!");
      }

      return employee;
    }
  }
}