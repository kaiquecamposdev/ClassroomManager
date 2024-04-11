using ClassroomManager.lib;
using ClassroomManager.repositories;
using ClassroomManager.models;

namespace ClassroomManager.usecases
{
  public class RegisterEmployeeUseCase(IEmployeesRepository employeesRepository)
  {
    private readonly IEmployeesRepository _employeesRepository = employeesRepository;
    private readonly BcryptProvider _bcryptProvider = new();

    public async Task<Employee> Execute(Employee data)
    {
      string password_hash = _bcryptProvider.HashPassword(data.Password);

      Employee employeeWithSameEnroll = _employeesRepository.FindByEnroll(data.Enroll);

      if (employeeWithSameEnroll != null)
      {
        throw new Exception("Funcionário já existe!");
      }

      Employee employee = await _employeesRepository.Create(new(data.Name, data.Telephone, password_hash, data.Enroll, data.Role));

      return employee;
    }
  }
}