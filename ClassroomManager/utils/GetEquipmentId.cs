using ClassroomManager.models;

namespace ClassroomManager.utils
{
  public class GetEquipmentId
  {
    public static string Execute(string equipmentString)
    {
      if (string.IsNullOrEmpty(equipmentString))
      {
        throw new ArgumentNullException(nameof(equipmentString));
      }

      equipmentString = equipmentString.TrimStart('=').TrimEnd(';');

      string[] keyValuePairs = equipmentString.Split(' ');

      string equipmentId = null;

      foreach (string pair in keyValuePairs)
      {
        string[] keyValue = pair.Split('=');

        if (keyValue.Length != 2)
        {
          throw new FormatException("Invalid equipment information format.");
        }

        string keyLowerCase = keyValue[0].ToLower();

        if (keyLowerCase == "id")
        {
          equipmentId = keyValue[1];
          break;
        }
      }

      return equipmentId;
    }
  }
}
