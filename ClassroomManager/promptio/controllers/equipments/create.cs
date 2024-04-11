using ClassroomManager.usecases.factories;
using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.usecases;

namespace ClassroomManager.promptio.controllers.equipments
{
  public class CreateEquipment
  {
    private readonly SharpromptProvider _prompt = new();

    public async Task Execute()
    {
      Console.Clear();
      Console.WriteLine("Criação de Equipamentos\n");

      string name = _prompt.GetStringInput("Nome do equipamento");
      string model = _prompt.GetStringInput("Modelo do equipamento");
      string brand = _prompt.GetStringInput("Marca do equipamento");
      string? description = _prompt.GetStringInput("Descrição do equipamento");
      int quantity = _prompt.GetIntInput("Quantidade do equipamento");

      string statusString = _prompt.Select("Status do equipamento", new[] { "Disponível", "Reservado", "Emprestado" });
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

      string options = _prompt.Select("Deseja finalizar?", new[] { "Finalizar", "Criar Novamente", "Sair" });

      try
      {
        switch (options)
        {
          case "Finalizar":
            break;
          case "Criar Novamente":
            await Execute();
            break;
          case "Sair":
            return;
        }
        Equipment equipment = new(name, model, brand, description, quantity, status);

        CreateEquipmentUseCase equipmentUseCase = MakeCreateEquipmentUseCase.Create();
        await equipmentUseCase.Execute(equipment);

        Console.Clear();
        Console.WriteLine("Equipamento criado com sucesso!");

        return;
      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
