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
    public void Remove(string id);
    public List<Equipment> GetAll();
    public Equipment FindById(string id);
    public Equipment FindByModel(string model);
    public Equipment FindByBrand(string brand);
    public Equipment FindByStatus(STATUS status);
  }
}
