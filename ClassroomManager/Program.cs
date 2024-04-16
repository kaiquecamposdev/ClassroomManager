using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.promptio.controllers;

namespace ClassroomManager
{
  class Program
  {
    private readonly SharpromptProvider _prompt = new();

    static void Main(string[] args)
    {
      new Program().HandleUserSelection();
    }

    private void HandleUserSelection()
    {
      EmployeeController employeeController = new();

      Console.Clear();
      Console.WriteLine("Bem-vindo ao Classroom Manager do Colégio Vencer Sempre!\n");

      string options = _prompt.Select("Selecione uma opção", new[] { "Iniciar Sessão", "Cadastro", "Sair" });

      switch (options)
      {
        case "Iniciar Sessão":
          Employee employee = employeeController.Authenticate();

          if (employee != null)
          {
            Console.Clear();
            Console.WriteLine("Usuário autenticado com sucesso!");
            Task.Delay(500).Wait();

            ShowMenu(employee);
          }
          break;
        case "Cadastro":
          employeeController.Register();

          Console.Clear();
          Console.WriteLine("Usuário cadastrado com sucesso!");
          Task.Delay(500).Wait();
          break;
        case "Sair":
          string exitOption = _prompt.Select("Tem certeza que deseja sair?", new[] { "Sim", "Não" });

          if (exitOption == "Não")
          {
            HandleUserSelection();
          }

          Console.WriteLine("Até mais!");
          return;
      }
    }
    private static void ShowMenu(Employee employee)
    {
      Menu menu = new(employee);

      menu.ShowMenu();
    }
  }
}