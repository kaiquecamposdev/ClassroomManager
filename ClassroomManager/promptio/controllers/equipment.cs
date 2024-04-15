using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.usecases;
using ClassroomManager.usecases.errors;
using ClassroomManager.usecases.factories;

namespace ClassroomManager.promptio.controllers
{
  public class EquipmentController
  {
    public static void Create(Equipment equipment)
    {
      try
      {
        CreateEquipmentUseCase equipmentUseCase = MakeCreateEquipmentUseCase.Create();
        equipmentUseCase.Execute(equipment);

        Console.Clear();
        Console.WriteLine("Equipamento criado com sucesso!");
        Task.Delay(500).Wait();

        return;
      } catch (InvalidCredentialsError err)
      {
        if (err is InvalidCredentialsError)
        {
          Console.WriteLine(err.Message);
        }

        throw;
      }
    }
    public static List<Equipment> Consult()
    {
      try
      {
        ConsultEquipmentUseCase equipmentUseCase = MakeConsultEquipmentUseCase.Create();
        List<Equipment> equipments = equipmentUseCase.Execute();        

        return equipments;
      }
      catch (ResourceNotFoundError err)
      {
        if (err is ResourceNotFoundError)
        {
          Console.WriteLine(err.Message);
        }

        throw;
      }
    }
  }
}
