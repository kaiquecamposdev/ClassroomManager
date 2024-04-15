using System.Globalization;

namespace ClassroomManager.utils
{
  public class DateFormat
  {
    public static string Execute(DateTime date)
    {
      CultureInfo lang = new("pt-BR");
      DateTimeFormatInfo formatter = lang.DateTimeFormat;

      string formattedDate = date.ToString(formatter.ShortDatePattern);
      string formattedHour = date.ToString(formatter.LongTimePattern);

      string formattedDateAndhour = date.ToString(formattedDate + " " + formattedHour);

      return formattedDateAndhour;
    }
  }
}
