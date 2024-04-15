using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.repositories;
using ClassroomManager.usecases.errors;

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
        throw new InvalidCredentialsError();
      }

      bool passwordMatch = _bcryptProvider.VerifyPassword(data.Password, employee.Password);

      if (!passwordMatch)
      {
        throw new InvalidCredentialsError();
      }

      return employee;
    }
  }
}