using System;
using MySql.Data.MySqlClient;
using AirlinePlanner;

namespace AirlinePlanner
{
  public class DB
  {
    public static MySqlConnection Connection()
    {
      MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}
