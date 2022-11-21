using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Peluqueria
{
    class controlCortes
    {
        public string ctrlCortes(Cortes cortes)
        {
            modeloCortes modelo = new modeloCortes();
            string rta = "";
            if ((cortes.IdP==0) || (string.IsNullOrEmpty(cortes.TipoC)) || (string.IsNullOrEmpty(cortes.DniC)) || (cortes.Fecha==null))
                rta = "Datos incompletos";
            else
            {
                modelo.registrarCorte(cortes);
                rta = "¡Se Registro Correctamente!";
            }
            return rta;
        }
    }
}
