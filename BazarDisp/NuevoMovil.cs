using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarDisp
{
    class NuevoMovil
    {
        public string Nombre { set; get; }
        public string Marca { set; get; }
        public string Color { set; get; }
        public string Tamaño { set; get; }


        public NuevoMovil()
        {

        }

        public NuevoMovil(string nom, string marc, string color, string tam)
        {
            Nombre = nom;
            Marca = marc;
            Color = color;
            Tamaño = tam;
        }
    }
}
