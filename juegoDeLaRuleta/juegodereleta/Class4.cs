using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegodereleta
{
    internal class Estadisticas
    {
        public int TotalGiros { get; set; }
        public Dictionary<int, int> NumerosMasJugados { get; set; }
        public Dictionary<Color, int> ColoresMasJugados { get; set; }
        public Dictionary<bool, int> ParesImparesMasJugados { get; set; }

        public Estadisticas()
        {
            TotalGiros = 0;
            NumerosMasJugados = new Dictionary<int, int>();
            ColoresMasJugados = new Dictionary<Color, int>();
            ParesImparesMasJugados = new Dictionary<bool, int>();
        }

        public void ActualizaEstadisticas(int numero, Color color, bool par)
        {
            TotalGiros++;

            if (!NumerosMasJugados.ContainsKey(numero))
            {
                NumerosMasJugados[numero] = 0;
            }
            NumerosMasJugados[numero]++;

            if (!ColoresMasJugados.ContainsKey(color))
            {
                ColoresMasJugados[color] = 0;
            }
            ColoresMasJugados[color]++;

            if (!ParesImparesMasJugados.ContainsKey(par))
            {
                ParesImparesMasJugados[par] = 0;
            }
            ParesImparesMasJugados[par]++;
        }
    }
}
