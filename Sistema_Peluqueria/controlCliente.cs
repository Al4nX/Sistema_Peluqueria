using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Peluqueria
{
    class controlCliente
    {
        public string ctrlRegistroClientes(Clientes cliente)
        {
            modeloCliente modelo = new modeloCliente();
            string rta = "";
            if ((string.IsNullOrEmpty(cliente.DNI)) || (string.IsNullOrEmpty(cliente.Apellido)) || (string.IsNullOrEmpty(cliente.Nombre)) || (string.IsNullOrEmpty(cliente.Domicilio)) || (string.IsNullOrEmpty(cliente.CP)) || (string.IsNullOrEmpty(cliente.Sexo)) || (cliente.FechaN == null) || (string.IsNullOrEmpty(cliente.Telefono)) || (string.IsNullOrEmpty(cliente.Correo)))
                rta = "Datos incompletos";
            else
            {
                if (modelo.existeCliente(cliente))
                    rta = "¡El DNI  " + cliente.DNI + " no está  disponible!";
                else
                {
                    modelo.registrarCliente(cliente);
                    rta = "¡Se Registro Correctamente!";
                }
            }
            return rta;
        }
    }
}