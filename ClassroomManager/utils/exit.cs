using ClassroomManager.lib;

namespace ClassroomManager.utils
{
  public class Exit
  {

    private readonly SharpromptProvider _prompt = new();

    public void Execute()
    {
      string option;
      do
      {
        option = _prompt.Select("Tem certeza que deseja sair?", new[] { "Sim", "Não" });
      } while (option != "Sim" && option != "Não");

      if (option == "Sim")
      {
        Console.WriteLine("Até mais!");
        return;
      }
    }
  }
}
