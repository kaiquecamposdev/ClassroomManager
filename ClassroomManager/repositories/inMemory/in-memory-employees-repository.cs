using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManager.repositories.inMemory
{
  public class InMemoryEmployeesRepository : IEmployeesRepository
  {
    private List<Employee> items = new List<Employee>();

    public Employee Create(Employee data)
    {
      
    }

    public Employee FindById(string id)
    {
      throw new NotImplementedException();
    }

    public void Remove(string id)
    {
      throw new NotImplementedException();
    }
  }
}
