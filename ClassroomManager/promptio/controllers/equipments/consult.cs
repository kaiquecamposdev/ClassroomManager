using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.usecases;
using ClassroomManager.usecases.factories;
using ClassroomManager.utils;
using ConsoleTables;
using System.Diagnostics;

namespace ClassroomManager.promptio.controllers.equipments
{
  public class ConsultEquipment
  {
    private readonly SharpromptProvider _prompt = new();

    public void Execute()
    {
      Console.Clear();
      Console.WriteLine("Consultor de Equipamentos\n");

      try
      {
        ConsultEquipmentUseCase equipmentUseCase = MakeConsultEquipmentUseCase.Create();
        List<Equipment> equipments = equipmentUseCase.Execute();

        Console.WriteLine("Equipamentos:\n");

        var tableOptions = _prompt.Select("Selecione uma das opções", new[] { 
          "Sem ordenação", 
          "Ordernar por Nome", 
          "Ordernar por Marca", 
          "Ordernar por Status", 
          "Voltar" 
        });

        switch (tableOptions)
        {
          case "Sem ordenação":
            break;
          case "Ordernar por Nome":
            equipments = equipments.OrderBy(row => row.Name).ToList();
            break;
          case "Ordernar por Marca":
            equipments = equipments.OrderBy(row => row.Brand).ToList();
            break;
          case "Ordernar por Status":
            equipments = equipments.OrderBy(row => row.Status).ToList();
            break;
          case "Voltar":
            return;
        }

        ConsoleTable table = new("Nome", "Modelo", "Marca", "Descrição", "Quantidade", "Status");

        PrintTable printTable = new();
        printTable.Execute(table, equipments);

        string lastOption = _prompt.Select("O que deseja fazer", new[] { "Voltar", "Sair" });

        if (lastOption == "Voltar")
        {
          Execute();
        }

        return;
      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
