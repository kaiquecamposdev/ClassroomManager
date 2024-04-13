using ClassroomManager.models;

namespace ClassroomManager.utils.interfaces
{
    public interface IPlugins
    {
        void Register();
        Employee AuthenticateEmployee();
        void CreateEquipment();
        void ConsultEquipment();
        void RequestEquipment();
    }
}
