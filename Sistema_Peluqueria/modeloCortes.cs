using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Peluqueria
{
    class modeloCortes
    {
        static MySqlConnection miConexion = conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public bool existeUsuario(Usuarioo user)
        {
            bool rta = false;
            miConexion.Open();
            sql = "Select * from cortes where User Like @id";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@id", user.Usuario);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool registrarCorte(Cortes corte)
        {
            miConexion.Open();
            sql = "INSERT INTO cortes (id, idP, tipoC, dniC, fecha)" + " VALUES(@id, @idP, @tipoC, @dniC, @fecha)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@id", corte.ID);
            comando.Parameters.AddWithValue("@idP", corte.IdP);
            comando.Parameters.AddWithValue("@tipoC", corte.TipoC);
            comando.Parameters.AddWithValue("@dniC", corte.DniC);
            comando.Parameters.AddWithValue("@fecha", corte.Fecha);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}