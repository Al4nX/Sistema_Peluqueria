using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Peluqueria
{
    class Cortes
    {
        static int id;
        static int idP;
        static string tipoC;
        static string dniC; 
        static DateTime fecha;

        public int ID { get => id; set => id = value; }
        public int IdP { get => idP; set => idP = value; }
        public string TipoC { get => tipoC; set => tipoC = value; }
        public string DniC { get => dniC; set => dniC = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
