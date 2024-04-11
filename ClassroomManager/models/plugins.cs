using ClassroomManager.models.interfaces;
using ClassroomManager.promptio.controllers.employees;
using ClassroomManager.promptio.controllers.equipments;


namespace ClassroomManager.models
{
    public class Plugins : IPlugins
    {
        private readonly RegisterEmployee _registerEmployee = new();
        private readonly Authenticate _authenticateEmployee = new();
        private readonly CreateEquipment _createEquipment = new();

        public async Task RegisterEmployee()
        {
          await _registerEmployee.Execute();
        }
        public Employee AuthenticateEmployee()
        {
          Employee employee = _authenticateEmployee.Execute();

          return employee;  
        }
        public async Task CreateEquipment()
        {
          await _createEquipment.Execute();
        }
    }
}
