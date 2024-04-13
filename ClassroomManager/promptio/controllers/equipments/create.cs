using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.usecases;
using ClassroomManager.usecases.factories;

namespace ClassroomManager.promptio.controllers.equipments
{
  public class CreateEquipment
  {
    private readonly SharpromptProvider _prompt = new();

    public void Execute()
    {
      Console.Clear();
      Console.WriteLine("Criação de Equipamentos\n");

      string name = _prompt.GetStringInput("Nome");
      string model = _prompt.GetStringInput("Modelo");
      string brand = _prompt.GetStringInput("Marca");
      string? description = _prompt.GetStringInput("Descrição");
      int quantity = _prompt.GetIntInput("Quantidade");

      string statusString = _prompt.Select("Status", new[] { "Disponível", "Reservado", "Emprestado" });
      STATUS status = STATUS.AVAILABLE;

      switch (statusString)
      {
        case "Disponível":
          status = STATUS.AVAILABLE;
          break;
        case "Reservado":
          status = STATUS.RESERVED;
          break;
        case "Emprestado":
          status = STATUS.BORROWED;
          break;
      }

      string options = _prompt.Select("Deseja finalizar?", new[] { "Sim", "Não" });

      try
      {
        switch (options)
        {
          case "Sim":
            break;
          case "Não":
            Execute();
            break;
        }
        Equipment equipment = new(name, model, brand, description, quantity, status);

        CreateEquipmentUseCase equipmentUseCase = MakeCreateEquipmentUseCase.Create();
        equipmentUseCase.Execute(equipment);

        Console.Clear();
        Console.WriteLine("Equipamento criado com sucesso!");
        Task.Delay(500).Wait();

        return;
      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
