namespace ClassroomManager.utils
{
  public enum MenuOption
  {
    ConsultEquipment,
    RequestEquipment,
    CreateEquipment,
    Exit
  }
  public interface IMenu
  {
    void ShowMenu();
  }
}
