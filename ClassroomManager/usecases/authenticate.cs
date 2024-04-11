using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.repositories;
using ClassroomManager.repositories.json;

namespace ClassroomManager.usecases
{
  public class AuthenticateUseCase(IEmployeesRepository employeesRepository)
  {
    public readonly IEmployeesRepository _employeesRepository = employeesRepository;
    public readonly BcryptProvider _bcryptProvider = new();

    public Employee Execute(IAuthenticateEmployee data)
    {
      Employee employee = _employeesRepository.FindByEnroll(data.Enroll);

      bool passwordMatch = _bcryptProvider.VerifyPassword(data.Password, employee.Password);

      if (passwordMatch == false)
      {
        throw new Exception("Credenciais inválidas!");
      }

      return employee ?? throw new Exception("Funcionário não existe!");
    }
  }
}