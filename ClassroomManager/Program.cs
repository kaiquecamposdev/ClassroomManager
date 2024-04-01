using ClassroomManager.Promptio.Controllers.Employees;

namespace ClassroomManager
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bem-vindo ao Classroom Manager!");
      
      string result = Authorization.Execute();

      Console.WriteLine(result);
    }
  }
}