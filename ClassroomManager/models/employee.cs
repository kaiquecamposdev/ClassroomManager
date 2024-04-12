namespace ClassroomManager.models
{
  public class Employee(string name, int? telephone, string password, int enroll, ROLE role) : IEmployee
  {
    public string Id { get; private set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = name;
    public int? Telephone { get; set; } = telephone;
    public string Password { get; set; } = password;
    public int Enroll { get; set; } = enroll;
    public ROLE Role { get; set; } = role;
  }
}