using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_13_04_2024.clase_padre;

namespace clase_13_04_2024.clase_hijo
{
    internal class Playstation:ClsConsola
    {
        public string ModeloControlador {  get; set; }

        public String MostrarDetallesPlay()
        {
            return MostrarDetalles() + "COntrolador:" + ModeloControlador;
        }
    }


}
