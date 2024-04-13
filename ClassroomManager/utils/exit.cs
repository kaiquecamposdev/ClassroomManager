using ClassroomManager.lib;
using ClassroomManager.models;

namespace ClassroomManager.utils
{
  public class Exit
  {

    private readonly SharpromptProvider _prompt = new();

    public void Execute(string message)
    {
      string option;
      do
      {
        option = _prompt.Select(message, new[] { "Sim", "Não" });
      } while (option != "Sim" && option != "Não");

      if (option == "Sim")
      {
        Console.WriteLine("Até mais!");
        return;
      } else
      {
        
      }
    }
  }
}
