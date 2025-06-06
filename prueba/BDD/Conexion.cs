using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace finanzasApp.BDD
{
    class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "finanzas_app";
        private string user = "kevin";
        private string password = "1234";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database +
                ";DataSource=" + server +
                "; User Id= " + user +
                "; Password= " + password;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }
    }
}
