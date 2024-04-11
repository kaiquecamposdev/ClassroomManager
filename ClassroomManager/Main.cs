using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using Sharprompt;
using System.Runtime.InteropServices;

namespace ClassroomManager
{
  class Program
  {
    private readonly SharpromptProvider prompt = new();
    private readonly Plugins plugins = new();

    static void Main(string[] args)
    {
      new Program().HandleUserSelection();
    }

    private void HandleUserSelection()
    {
      Console.Clear();
      Console.WriteLine("Bem-vindo ao Classroom Manager do Colégio Vencer Sempre!\n");

      string options = prompt.Select("Selecione uma opção", new[] { "Iniciar Sessão", "Cadastro", "Sair" });

      switch (options)
      {
        case "Iniciar Sessão":
          Employee employee = plugins.AuthenticateEmployee();

          ShowMenu(employee);
          break;
        case "Cadastro":
          RegisterEmployee();
          break;
        case "Sair":
          string option;
          do
          {
            option = prompt.Select("Tem certeza que deseja sair?", new[] { "Sim", "Não" });
          } while (option != "Sim" && option != "Não");

          if (option == "Sim")
          {
            Console.WriteLine("Até mais!");
            return;
          }
          break;
      }
      HandleUserSelection();
    }
    private void RegisterEmployee()
    {
      plugins.RegisterEmployee();

      HandleUserSelection();
    }
    private static void ShowMenu(Employee employee)
    {
      Menu menu = new(employee);
      menu.ShowMenu();
    }
  }
}