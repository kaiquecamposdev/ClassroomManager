using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.utils;
using ClassroomManager.utils.interfaces;

public class Menu : IMenu
{
  private readonly Employee _employee;
  private readonly Plugins plugins = new();
  private readonly SharpromptProvider _prompt = new();

  public Menu(Employee employee)
  {
    _employee = employee;
  }

  public void ShowMenu()
  {
    while (true)
    {
      var option = GetMenuOption();

      switch (option)
      {
        case MenuOption.ConsultEquipment:
          ConsultEquipment();
          break;
        case MenuOption.RequestEquipment:
          RequestEquipment();
          break;
        case MenuOption.CreateEquipment:
          CreateEquipment();
          break;
        case MenuOption.Exit:
          string exitOption;
          do
          {
            exitOption = _prompt.Select("Tem certeza que deseja sair?", new[] { "Sim", "Não" });
          } while (exitOption != "Sim" && exitOption != "Não");

          if (exitOption == "Sim")
          {
            Console.WriteLine("Até mais!");
            return;
          }
          else
          {
            ShowMenu();
          }
          return;
      }
    }
  }

  private MenuOption GetMenuOption()
  {
    Console.Clear();
    Console.WriteLine($"Bem-vindo, {_employee.Name}!\n");

    string[] options = [
      "Consultar Equipamentos",
      "Solicitar Equipamento",
      "Sair"
    ];

    if (_employee.Role.Equals(ROLE.ADMIN))
    {
      options = [
        "Consultar Equipamentos",
        "Solicitar Equipamento",
        "Criar Equipamento",
        "Sair"
      ];
    }

    string selectedOptionString = _prompt.Select("Selecione uma das opções", options);

    MenuOption selectedOption;

    switch (selectedOptionString)
    {
      case "Consultar Equipamentos":
        selectedOption = MenuOption.ConsultEquipment;
        break;
      case "Solicitar Equipamento":
        selectedOption = MenuOption.RequestEquipment;
        break;
      case "Criar Equipamento":
        selectedOption = MenuOption.CreateEquipment;
        break;
      case "Sair":
        selectedOption = MenuOption.Exit;
        break;
      default:
        selectedOption = MenuOption.Exit;
        break;
    }

    return selectedOption;
  }

  private void ConsultEquipment()
  {
    plugins.ConsultEquipment();
  }

  private void RequestEquipment()
  {
    // Implementar a lógica para solicitar equipamentos
  }

  private void CreateEquipment()
  {
    plugins.CreateEquipment();
  }
}