using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManager.models.interfaces
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
