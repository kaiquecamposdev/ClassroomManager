namespace ClassroomManager.lib.interfaces
{
    internal interface ISharpromptInputProvider
    {
        int GetIntInput(string message);
        string GetStringInput(string message);
        string GetPasswordInput(string message);
        bool GetBoolInput(string message);
        string Select(string message, string[] options);
        IEnumerable<string> MultiSelect(string message, string[] options, int pageSize);
    }
}
