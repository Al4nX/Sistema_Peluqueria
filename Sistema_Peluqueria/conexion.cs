using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Peluqueria
{
    class conexion
    {
        static string servidor = "server = 127.0.0.1";
        static string puerto = "port = 3306";
        static string username = "username = root";
        static string password = "password = ";
        static string bd = "database = peluqueria";
        public static MySqlConnection getConexion()
        {
            string cadenaConexion = servidor + ";" + puerto + ";" + username + ";" + password + ";" + bd + "; SSL Mode=0";
            return new MySqlConnection(cadenaConexion);
        }
    }
}
