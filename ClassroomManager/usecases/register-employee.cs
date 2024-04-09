using ClassroomManager.lib;
using ClassroomManager.repositories;
using ClassroomManager.models;

namespace ClassroomManager.usecases
{
  public class RegisterEmployeeUseCase(IEmployeesRepository employeesRepository)
  {
    private readonly IEmployeesRepository _employeesRepository = employeesRepository;
    private readonly BcryptProvider _bcryptProvider = new();

    public Employee Execute(Employee data)
    {
      var password_hash = _bcryptProvider.HashPassword(data.Password);

      var employeeWithSameEnroll = _employeesRepository.FindByEnroll(data.Enroll);

      if (employeeWithSameEnroll != null)
      {
        throw new Exception("Funcionário já existe!");
      }

      var employee = _employeesRepository.Create(new Employee(data.Name, data.Telephone, password_hash, data.Enroll, data.Role));

      return employee;
    }
  }
}