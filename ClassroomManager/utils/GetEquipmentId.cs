namespace ClassroomManager.utils
{
  public class GetEquipmentId
  {
    public static string Execute(string equipmentString)
    {
      var keyValuePairs = equipmentString.Split(' ');

      foreach (var pair in keyValuePairs)
      {
        var parts = pair.Split('=');

        if (parts[0].Equals("Id", StringComparison.OrdinalIgnoreCase))
        {       
          return parts[1];
        }
      }

      return null;
    }
  }
}
