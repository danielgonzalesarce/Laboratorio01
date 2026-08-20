using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace lab01
{
    internal class punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        // La fórmula de la distancia 
        public double CalcularDistancia(punto otroPunto)
        {
            return Math.Sqrt(Math.Pow(otroPunto.X - this.X, 2) + Math.Pow(otroPunto.Y - this.Y, 2));
        }
    }
}