using ClassroomManager.lib;
using ClassroomManager.promptio.controllers.employees;

namespace ClassroomManager 
{
  class Program
  {
    static void Main(string[] args)
    {
      SharpromptProvider _inputProvider = new();

      Console.WriteLine("Bem-vindo ao Classroom Manager!\b");

      bool acceptRegister = _inputProvider.GetBoolInput("Já possui cadastro?");

      if (acceptRegister)
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
}