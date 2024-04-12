using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.usecases;
using ClassroomManager.usecases.factories;
using ConsoleTables;

namespace ClassroomManager.promptio.controllers.equipments
{
  public class ConsultEquipment
  {

    public List<Equipment> Execute()
    {
      Console.Clear();
      Console.WriteLine("Consultor de Equipamentos\n");

      try
      {
        ConsultEquipmentUseCase equipmentUseCase = MakeConsultEquipmentUseCase.Create();
        List<Equipment> equipments = equipmentUseCase.Execute();

        Console.WriteLine("Equipamentos:\n");

        ConsoleTable table = new("Id", "Nome", "Modelo", "Quantidade", "Marca", "Descrição");

        for (int i = 0; i < equipments.Count; i++)
        {
          Equipment equipment = equipments[i];
          table.AddRow(equipment.Id, equipment.Name, equipment.Model, equipment.Quantity, equipment.Brand, equipment.Description);
        }

        table.Write();

        return equipments;
      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
