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
      Employee employee = _employeesRepository.FindByEnroll(data.Enroll) ?? throw new Exception("Funcionário não existe!");
      bool passwordMatch = _bcryptProvider.VerifyPassword(data.Password, employee.Password);

      if (passwordMatch == false)
      {
        throw new Exception("Credenciais inválidas!");
      }

      return employee;
    }
  }
}