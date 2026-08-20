using System;

namespace lab01
{
    public class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double calcularArea()
        {
            return Base * Altura;
        }

        public double calcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}