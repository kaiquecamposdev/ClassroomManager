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

        string[] equipmentsArray;

        for (int i = 0; i < equipments.Count; i++)
        {
          Equipment equipment = equipments[i];

          equipmentsArray
        }

        IEnumerable<string> itemsChosenByTheUser = _prompt.MultiSelect("Equipamentos:", , 5);

      }
      catch (Exception e)
      {
        throw new Exception("Erro no sistema!", e);
      }
    }
  }
}
