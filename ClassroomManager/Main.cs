using ClassroomManager.lib;
using ClassroomManager.promptio.controllers.employees;
using ClassroomManager.Promptio.Controllers.Employees;

internal class Program
{
  private static void Main(string[] args)
  {
    var _inputProvider = new SharpromptProvider();

    Console.WriteLine("Bem-vindo ao Classroom Manager!");

    var acceptLogin = _inputProvider.GetBoolInput("Deseja fazer login?");

    if (acceptLogin)
    {
      Authenticate pluginAuthenticate = new();
      pluginAuthenticate.Execute();
    }
    else
    {
      Register pluginRegister = new();
      pluginRegister.Execute();
    }
  }
}