﻿using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.repositories;

namespace ClassroomManager.usecases
{
  public class RegisterUseCase(IEmployeesRepository employeesRepository)
  {
    private readonly IEmployeesRepository _employeesRepository = employeesRepository;
    private readonly BcryptProvider _bcryptProvider = new();

    public Employee Execute(Employee data)
    {
      string password_hash = _bcryptProvider.HashPassword(data.Password);

      Employee employeeWithSameEnroll = _employeesRepository.FindByEnroll(data.Enroll);

      if (employeeWithSameEnroll != null)
      {
        throw new Exception("Funcionário já existe.");
      }

      Employee employee = _employeesRepository.Create(new(data.Name, data.Telephone, password: password_hash, data.Enroll, data.Role));

      return employee;
    }
  }
}