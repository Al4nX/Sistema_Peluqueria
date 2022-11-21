using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Peluqueria
{
    class modeloUsuarios
    {
        static MySqlConnection miConexion = conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public bool existeUsuario(Usuarioo user)
        {
            bool rta = false;
            miConexion.Open();
            sql = "Select * from usuarios where User Like @user";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@User", user.Usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool registrarUsuario(Usuarioo user)
        {
            miConexion.Open();
            sql = "INSERT INTO usuarios (idUser, User, Password, Nombre, idTipoUser)" + " VALUES(@idUser, @User, @Password, @Nombre, @idTipoUser)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@idUser", null);
            comando.Parameters.AddWithValue("@User", user.Usuario);
            comando.Parameters.AddWithValue("@Password", user.Password);
            comando.Parameters.AddWithValue("@Nombre", user.Nombre);
            comando.Parameters.AddWithValue("@idTipoUser", user.IdTipo);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}
