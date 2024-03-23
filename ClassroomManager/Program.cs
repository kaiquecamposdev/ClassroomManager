using Sharprompt;

namespace ClassroomManager
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string name = Prompt.Input<string>("What's your name?");
      Console.WriteLine($"Olá, {name}!");

      string secret = Prompt.Password("Type new password", validators: new[] { Validators.Required(), Validators.MinLength(8) });
      Console.WriteLine("Password OK");

      bool answer = Prompt.Confirm("Are you ready?", defaultValue: true);
      Console.WriteLine($"Your answer is {answer}");
    }
  }
}
