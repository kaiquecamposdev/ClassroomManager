using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.usecases;
using ClassroomManager.usecases.factories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassroomManager.promptio.controllers.equipments
{
  public class RequestEquipments
  {
    private readonly SharpromptProvider _prompt = new();

    public void Execute()
    {
      Console.Clear();
      Console.WriteLine("Solicitação de Equipamentos\n");

      try
      {
        RequestEquipmentsUseCase requestEquipmentsUseCase = MakeRequestEquipmentsUseCase.Create();
        List<Equipment> equipments = requestEquipmentsUseCase.Execute();

        string[] equipmentsArray = new string[equipments.Count];

        for (int i = 0; i < equipments.Count; i++)
        {
          Equipment equipment = equipments[i];
          equipmentsArray[0] = " Nome=" + equipment.Name + " Marca=" + equipment.Brand + " Modelo=" + equipment.Model + " Id=" + equipment.Id;
        }

        string itemsChosenByTheUser = _prompt.Select("Equipamentos:", equipmentsArray);

        Console.Clear();
        Console.WriteLine("Equipamento solicitado com sucesso!");
        Task.Delay(500).Wait();
      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
