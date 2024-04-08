namespace ClassroomManager.models.interfaces
{
  public enum ROLE
  {
    ADMIN,
    TEACHER,
    COORDINATOR,
  }
  internal interface IEmployee
  {
    string Id { get; }
    string Name { get; set; }
    int? Telephone { get; set; }
    string Password { get; set; }
    int Enroll { get; set; }
    ROLE Role { get; set; }
  }
}
