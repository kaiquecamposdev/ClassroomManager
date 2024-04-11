﻿using ClassroomManager.models;

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
    public Task<Equipment> Create(Equipment employee);
    public Task Remove(string id);
    public Equipment FindById(string id);
    public Equipment FindByModel(string model);
    public Equipment FindByBrand(string brand);
    public Equipment FindByStatus(STATUS status);
  }
}