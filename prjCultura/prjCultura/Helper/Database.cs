using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prjCultura.Helper
{
    public class Database
    {
        public static MySqlConnection Connect()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "localhost"; //database server
            builder.UserID = "root"; //database username
            builder.Password = "usbw"; //database password
            builder.Database = "cultura"; //database name

            builder.ConnectionTimeout = 60;
            builder.Port = 3307;
            builder.AllowZeroDateTime = true;

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            conn.Open();
            return conn;
        }
    }
}
