using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;

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
          if (_employee.Role == ROLE.ADMIN)
          {
            CreateEquipment();
          }
          else
          {
            Console.WriteLine("Você não tem acesso a essa opção.");
          }
          break;
        case MenuOption.Exit:
          Console.WriteLine("Até mais!");
          return;
      }
    }
  }

  private MenuOption GetMenuOption()
  {
    Console.Clear();
    Console.WriteLine($"Bem-vindo, {_employee.Name}!\n");

    string selectedOptionString = _prompt.Select("Selecione uma das opções", new[] { 
      "Consultar Equipamentos", 
      "Solicitar Equipamento", 
      "Criar Equipamento", 
      "Sair" 
    });

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
    // Implementar a lógica para consultar equipamentos
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