using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBusted
{
    class Conexion
    {

        public static string connectionString = "server=dbayd1p2.co2sigosbh9v.us-east-2.rds.amazonaws.com;Port=3306;uid=admin;" + "pwd=admin123;database=block_buster_db";

        public static string ConnectionString
        {
            get { return connectionString;  }
        }
    }
}
