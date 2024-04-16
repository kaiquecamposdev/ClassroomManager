using ClassroomManager.CLI.interfaces;
using ClassroomManager.lib;
using ClassroomManager.models;
using ClassroomManager.models.interfaces;
using ClassroomManager.promptio.controllers;
using ClassroomManager.usecases;
using ClassroomManager.usecases.factories;
using ClassroomManager.utils;
using ConsoleTables;

public class Menu : IMenu
{
  private readonly Employee _employee;
  private readonly SharpromptProvider _prompt = new();
  private readonly EquipmentController _equipmentController = new();
  private readonly ReportController _reportController = new();

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
        case MenuOption.Report:
          Report();
          break;
        case MenuOption.CreateEquipment:
          CreateEquipment();
          break;
        case MenuOption.Exit:
          string exitOption = _prompt.Select("Tem certeza que deseja sair?", new[] { "Sim", "Não" });
          
          if (exitOption == "Não")
          {
            ShowMenu();
            return;
          }

          Console.WriteLine("Até mais!");
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
      "Relatório",
      "Sair"
    ];

    if (_employee.Role.Equals(ROLE.ADMIN))
    {
      options = [
        "Consultar Equipamentos",
        "Solicitação Equipamento",
        "Criar Equipamento",
        "Relatório",
        "Sair"
      ];
    }

    string selectedOptionString = _prompt.Select("Selecione uma das opções", options);

    var selectedOption = selectedOptionString switch
    {
      "Consultar Equipamentos" => MenuOption.ConsultEquipment,
      "Solicitar Equipamento" => MenuOption.RequestEquipment,
      "Criar Equipamento" => MenuOption.CreateEquipment,
      "Relatório" => MenuOption.Report,
      "Sair" => MenuOption.Exit,
      _ => MenuOption.Exit,
    };

    return selectedOption;
  }
  private void ConsultEquipment()
  {
    Console.Clear();
    Console.WriteLine("Consultor de Equipamentos\n");

    Console.WriteLine("Equipamentos:\n");

    string[] options = [
      "Sem ordenação",
      "Ordernar por Nome",
      "Ordernar por Marca",
      "Ordernar por Status",
      "Voltar"
    ];

    string tableOptions = _prompt.Select("Selecione uma das opções", options);

    List<Equipment> equipments = EquipmentController.Consult();

    switch (tableOptions)
    {
      case "Sem ordenação":
        break;
      case "Ordernar por Nome":
        equipments = [.. equipments.OrderBy(row => row.Name)];
        break;
      case "Ordernar por Marca":
        equipments = [.. equipments.OrderBy(row => row.Brand)];
        break;
      case "Ordernar por Status":
        equipments = [.. equipments.OrderBy(row => row.Status)];
        break;
      case "Voltar":
        return;
    }

    ConsoleTable table = new("Nome", "Modelo", "Marca", "Status");

    for (int i = 0; i < equipments.Count; i++)
    {
      Equipment equipment = equipments[i];
      string status = equipment.Status switch
      {
        STATUS.AVAILABLE => "Disponível",
        STATUS.RESERVED => "Reservado",
        STATUS.BORROWED => "Emprestado",
        _ => "Disponível",
      };
      table.AddRow(equipment.Name, equipment.Model, equipment.Brand, status);
    }
    table.Write();

    string lastOption = _prompt.Select("O que deseja fazer", new[] { "Voltar", "Sair" });

    if (lastOption == "Voltar")
    {
      ConsultEquipment();
    }

    return;
  }
  private void RequestEquipment()
  {
    Console.Clear();
    Console.WriteLine("Solicitação de Equipamentos\n");

    List<Equipment> equipments = EquipmentController.Consult();

    string[] equipmentsArray = new string[equipments.Count];

    for (int i = 0; i < equipments.Count; i++)
    {
      Equipment equipment = equipments[i];
      equipmentsArray[0] = " Nome=" + equipment.Name + " Marca=" + equipment.Brand + " Modelo=" + equipment.Model + " Id=" + equipment.Id;
    }

    string itemChosenByTheUser = _prompt.Select("Equipamentos:", equipmentsArray);

    string equipmentId = GetEquipmentId.Execute(itemChosenByTheUser);

    Console.WriteLine(equipmentId);
    return;

    ReportController.Generate(employeeId: _employee.Id, equipmentId);

    Console.Clear();
    Console.WriteLine("Equipamento solicitado com sucesso!");
    Task.Delay(500).Wait();

    return;
  }
  private void Report()
  {
    Console.Clear();
    Console.WriteLine("Relatório de solicitação de equipamentos\n");

    List<Report> reports = ReportController.GetByEmployeeId(employeeId: _employee.Id);
    List<Equipment> equipments = EquipmentController.Consult();

    ConsoleTable table = new("Nome do Equipamento", "Status", "Data de Solicitação");

    for (int i = 0; i < reports.Count; i++)
    {
      Report report = reports[i];

      Equipment equipment = equipments.Find(equipment => equipment.Id == report.EquipmentId);

      string status = equipment.Status switch
      {
        STATUS.AVAILABLE => "Disponível",
        STATUS.RESERVED => "Reservado",
        STATUS.BORROWED => "Emprestado",
        _ => "Disponível",
      };

      if (equipment.Status == STATUS.AVAILABLE)
      {
        return;
      }

      string dateFormatted = DateFormat.Execute(report.CreatedAt);

      table.AddRow(equipment.Name, status, dateFormatted);
    }
    table.Write();

    string lastOption = _prompt.Select("O que deseja fazer", new[] { "Voltar", "Sair" });

    if (lastOption == "Voltar")
    {
      Report();
    }

    return;
  }
  private void CreateEquipment()
  {
    Console.Clear();
    Console.WriteLine("Criação de Equipamentos\n");

    string name = _prompt.GetStringInput("Nome");
    string model = _prompt.GetStringInput("Modelo");
    string brand = _prompt.GetStringInput("Marca");
    string? description = _prompt.GetStringInput("Descrição");
    int quantity = _prompt.GetIntInput("Quantidade");

    string statusString = _prompt.Select("Status", new[] { "Disponível", "Reservado", "Emprestado" });
    var status = statusString switch
    {
      "Disponível" => STATUS.AVAILABLE,
      "Reservado" => STATUS.RESERVED,
      "Emprestado" => STATUS.BORROWED,
      _ => STATUS.AVAILABLE,
    };

    Equipment equipment = new(name, model, brand, description, quantity, status);

    EquipmentController.Create(equipment);

    return;
  }
  
}