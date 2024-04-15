using ClassroomManager.models;

namespace ClassroomManager.repositories
{
  public enum STATUS
  {
    AVAILABLE,
    RESERVED,
    BORROWED,
  }
  public interface IEquipmentsRepository
  {
    public Equipment Create(Equipment employee);
    public List<Equipment> GetAll();
    public Equipment FindById(string id);
    public Equipment FindByModel(string model);
  }
}
