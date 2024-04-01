using System.Data.SqlClient;
using System;
using System.Data;
using System.Data.Common;

namespace ClassroomManager.lib
{
  public sealed class SqlConnection : DbConnection, ICloneable
  {
    public SqlConnection(string connectionString)
    {
      ConnectionString = connectionString;
    }

    private static void CreateCommand(string queryString, string connectionString)
    {
      using (SqlConnection connection = new(connectionString))
      {
        SqlCommand command = new(queryString, connection);

        command.Connection.Open();
        command.ExecuteNonQuery();
      }
    }
  }
}
