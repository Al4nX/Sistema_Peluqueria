using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Peluqueria
{
    class modeloPeluqueros
    {
        static MySqlConnection miConexion = conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public bool existeCliente(Peluqueros peluqueros)
        {
            bool rta = false;
            miConexion.Open();
            sql = "Select * from peluqueros where dni Like @id";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@id", peluqueros.ID);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool registrarCliente(Peluqueros peluquero)
        {
            miConexion.Open();
            sql = "INSERT INTO clientes (id, dni, ape, nom, dom, cp, sexo, fechaN, tel, mail)" + "VALUES (@id, @dni, @ape, @nom, @dom, @cp, @sexo, @fechaN, @tel, @mail)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@Id", peluquero.ID);
            comando.Parameters.AddWithValue("@dni", peluquero.DNI);
            comando.Parameters.AddWithValue("@ape", peluquero.Apellido);
            comando.Parameters.AddWithValue("@nom", peluquero.Nombre);
            comando.Parameters.AddWithValue("@dom", peluquero.Domicilio);
            comando.Parameters.AddWithValue("@cp", peluquero.CP);
            comando.Parameters.AddWithValue("@sexo", peluquero.Sexo);
            comando.Parameters.AddWithValue("@fechaN", peluquero.FechaN);
            comando.Parameters.AddWithValue("@tel", peluquero.Telefono);
            comando.Parameters.AddWithValue("@mail", peluquero.Correo);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}
