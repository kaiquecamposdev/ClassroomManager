using ClassroomManager.models;
using ClassroomManager.promptio.controllers.employees;
using ClassroomManager.promptio.controllers.equipments;
using ClassroomManager.usecases;
using ClassroomManager.utils.interfaces;


namespace ClassroomManager.utils
{
    public class Plugins : IPlugins
  {
    private readonly Register _register = new();
    private readonly Authenticate _authenticateEmployee = new();
    private readonly CreateEquipment _createEquipment = new();
    private readonly ConsultEquipment _consultEquipment = new();
    private readonly RequestEquipments _requestEquipments = new();

    public void Register()
    {
      _register.Execute();
    }
    public Employee AuthenticateEmployee()
    {
      Employee employee = _authenticateEmployee.Execute();

      return employee;
    }
    public void CreateEquipment()
    {
      _createEquipment.Execute();
    }

    public void ConsultEquipment()
    {
      _consultEquipment.Execute();
    }

    public void RequestEquipments()
    {
      _requestEquipments.Execute();
    }
  }
}
