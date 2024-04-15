using ClassroomManager.lib.interfaces;

namespace ClassroomManager.lib
{
    public class SharpromptProvider : ISharpromptInputProvider
  {
    public int GetIntInput(string message)
    {
      return Sharprompt.Prompt.Input<int>(message);
    }

    public string GetStringInput(string message)
    {
      return Sharprompt.Prompt.Input<string>(message);
    }

    public string GetPasswordInput(string message)
    {
      return Sharprompt.Prompt.Password(message);
    }

    public bool GetBoolInput(string message)
    {
      return Sharprompt.Prompt.Confirm(message);
    }

    public string Select(string message, string[] options)
    {
      return Sharprompt.Prompt.Select(message, options);
    }

    public IEnumerable<string> MultiSelect(string message, string[] options, int pageSize)
    {
      return Sharprompt.Prompt.MultiSelect(message, options, pageSize);
    }
  }
}