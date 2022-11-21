using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Peluqueria
{
    class Clientes
    {
        //ATRIBUTOS
        static string dni;
        static string ape;
        static string nom;
        static string dom;
        static string cp;
        static string sexo;
        static DateTime fechaN;
        static string tel;
        static string mail;

        public string DNI { get => dni; set => dni = value; }
        public string Apellido { get => ape; set => ape = value; }
        public string Nombre { get => nom; set => nom = value; }
        public string Domicilio { get => dom; set => dom = value; }
        public string CP { get => cp; set => cp = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaN { get => fechaN; set => fechaN = value; }
        public string Telefono { get => tel; set => tel = value; }
        public string Correo { get => mail; set => mail = value; }
    }
}
