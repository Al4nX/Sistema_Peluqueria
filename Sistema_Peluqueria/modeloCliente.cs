using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_Peluqueria
{
    class modeloCliente
    {
        static MySqlConnection miConexion = conexion.getConexion();
        static string sql = "";
        static MySqlCommand comando;
        static MySqlDataReader reader;
        public bool existeCliente(Clientes cliente)
        {
            bool rta = false;
            miConexion.Open();
            sql = "Select * from clientes where dni Like @dni";
            comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@dni", cliente.DNI);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
                rta = true;
            miConexion.Close();
            return rta;
        }
        public bool registrarCliente(Clientes cliente)
        {
            miConexion.Open();
            sql = "INSERT INTO clientes (dni, ape, nom, dom, cp, sexo, fechaN, tel, mail)" + "VALUES (@dni, @ape, @nom, @dom, @cp, @sexo, @fechaN, @tel, @mail)";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            comando.Parameters.AddWithValue("@dni", cliente.DNI);
            comando.Parameters.AddWithValue("@ape", cliente.Apellido);
            comando.Parameters.AddWithValue("@nom", cliente.Nombre);
            comando.Parameters.AddWithValue("@dom", cliente.Domicilio);
            comando.Parameters.AddWithValue("@cp", cliente.CP);
            comando.Parameters.AddWithValue("@sexo", cliente.Sexo);
            comando.Parameters.AddWithValue("@fechaN", cliente.FechaN);
            comando.Parameters.AddWithValue("@tel", cliente.Telefono);
            comando.Parameters.AddWithValue("@mail", cliente.Correo);
            int tuplas = comando.ExecuteNonQuery();
            miConexion.Close();
            if (tuplas > 0)
                return true;
            else
                return false;
        }
    }
}
