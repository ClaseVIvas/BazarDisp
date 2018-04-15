using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarDisp
{
    class NuevoMovil
    {
        string Nombre { set; get; }
        string Marca { set; get; }
        string Color { set; get; }
        int Tamaño { set; get; }


        public NuevoMovil(string nom, string marc, string color, int tam)
        {
            nom = Nombre;
            marc = Marca;
            color = Color;
            tam = Tamaño;
        }
    }
}
