
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TpdNoche.modelo
{
    internal class Conexion
    {
        private MySqlConnection conn;

        private string DB_NAME = "test_lurin";
        private string SERVER = "localhost";
        private string DB_USER = "root";
        private string DB_PASS = "";

        public Conexion()
        {
            string cadenaConexion =
             $"Server={SERVER};Database={DB_NAME};User ID={DB_USER};Password={DB_PASS};";

            conn = new MySqlConnection(cadenaConexion) ;

        }

        public MySqlConnection getConexion { get => conn ; }

        public void Open()
        {
            if(conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State==System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        //'server=localhost;user id=root;password=12345;database=testdb'.



    }
}
