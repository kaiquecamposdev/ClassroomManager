using ClassroomManager.models;

namespace ClassroomManager.utils
{
  public interface IPlugins
  {
    void Register();
    Employee AuthenticateEmployee();
    void CreateEquipment();
    void ConsultEquipment();
  }
}
