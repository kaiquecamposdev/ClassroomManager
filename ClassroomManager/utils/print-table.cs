using ClassroomManager.models;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManager.utils
{
  public class PrintTable
  {
    public void Execute(ConsoleTable table, List<Equipment> equipments)
    {
      for (int i = 0; i < equipments.Count; i++)
      {
        Equipment equipment = equipments[i];

        string status;

        switch (equipment.Status)
        {
          case STATUS.AVAILABLE:
            status = "Disponível";
            break;
          case STATUS.RESERVED:
            status = "Reservado";
            break;
          case STATUS.BORROWED:
            status = "Emprestado";
            break;
          default:
            status = "Disponível";
            break;
        }

        table.AddRow(equipment.Name, equipment.Model, equipment.Brand, equipment.Description, status);
      }
      table.Write();
    }
  }
}
