namespace ClassroomManager.CLI.interfaces
{
    public enum MenuOption
    {
        ConsultEquipment,
        RequestEquipment,
        CreateEquipment,
        Report,
        Exit
    }
    public interface IMenu
    {
        void ShowMenu();
    }
}
