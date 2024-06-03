using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodereleta
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public int DineroInicial { get; set; }
        public int DineroActual { get; set; }

        public Jugador(string nombre, int dineroInicial)
        {
            Nombre = nombre;
            DineroInicial = dineroInicial;
            DineroActual = dineroInicial;
        }
    }
}
