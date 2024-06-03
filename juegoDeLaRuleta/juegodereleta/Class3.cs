using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodereleta
{
    internal class Apuestas
    {
        public int Numero { get; set; }
        public int Cantidad { get; set; }
        public Color Color { get; set; }
        public bool Par { get; set; }

        public Apuestas(int numero, int cantidad, Color color, bool par)
        {
            Numero = numero;
            Cantidad = cantidad;
            Color = color;
            Par = par;
        }
    }
}
