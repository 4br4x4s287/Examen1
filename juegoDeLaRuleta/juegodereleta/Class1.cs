using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodereleta
{
   

    internal class Ruleta
    {
        private static readonly Random _random = new Random();

        public int Gira()
        {
            return _random.Next(0, 37);
        }

        public Color ObtenerColor(int numero)
        {
            if (numero == 0)
            {
                return Color.Negro; // El 0 no tiene color
            }
            else if (EsNumeroNegro(numero))
            {
                return Color.Negro;
            }
            else
            {
                return Color.Rojo;
            }
        }

        private bool EsNumeroNegro(int numero)
        {
            int[] numerosNegros = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            return Array.Exists(numerosNegros, n => n == numero);
        }
    }
}
