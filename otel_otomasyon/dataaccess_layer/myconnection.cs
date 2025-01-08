using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;
namespace otel_otomasyon.dataaccess_layer
{
    public class myconnection
    {
        public MySqlConnection Getconnection()
        {
            MySqlConnection connection = new MySqlConnection("Server=172.21.54.253;Database=25_132330062;User=25_132330062;Password=!nif.ogr62KU;");
            connection.Open();
            return connection;
        }
    }
}
