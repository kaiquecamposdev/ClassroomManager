using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.promptio.controllers.employees;
using ClassroomManager.utils;

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
          Employee employee = Authenticate();

          Console.Clear();
          Console.WriteLine("Usuário autenticado com sucesso!");
          Task.Delay(500).Wait();

          ShowMenu(employee);
          break;
        case "Cadastro":
          Register();

          Console.Clear();
          Console.WriteLine("Usuário cadastrado com sucesso!");
          Task.Delay(500).Wait();
          break;
        case "Sair":
          Exit exit = new();

          exit.Execute("Tem certeza que deseja sair?");
          return;
      }
      HandleUserSelection();
    }
    private void Register()
    {
      plugins.Register();

      HandleUserSelection();
    }

    private Employee Authenticate()
    {
      Employee employee = plugins.AuthenticateEmployee();

      return employee;
    }
    private static void ShowMenu(Employee employee)
    {
      Menu menu = new(employee);

      menu.ShowMenu();
    }
  }
}