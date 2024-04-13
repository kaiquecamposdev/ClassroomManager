﻿namespace ClassroomManager.utils.interfaces
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
