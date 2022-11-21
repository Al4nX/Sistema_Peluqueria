using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Sistema_Peluqueria
{
    class modeloSesion
    {
        static MySqlConnection miConexion = conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public Usuarioo miUsuario(String usuario)
        {
            Usuarioo user = null;
            miConexion.Open();
            sql = "Select * FROM usuarios where User Like @User";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@User", usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = new Usuarioo();
                    user.Id = int.Parse(reader["idUser"].ToString());
                    user.Usuario = reader["User"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Nombre = reader["Nombre"].ToString();
                    user.IdTipo = int.Parse(reader["idTipoUser"].ToString());
                }
            }
            miConexion.Close();
            return user;
        }
    }
}
