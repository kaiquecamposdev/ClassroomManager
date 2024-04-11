namespace ClassroomManager.models.interfaces
{
  public interface IPlugins
  {
    Task RegisterEmployee();
    Employee AuthenticateEmployee();
    Task CreateEquipment();
  }
}
