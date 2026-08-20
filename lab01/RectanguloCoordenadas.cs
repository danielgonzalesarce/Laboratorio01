using System;
using System.Collections.Generic;
using System.Text;

namespace lab01
{
    internal class RectanguloCoordenadas
    {
        // Propiedades auto-implementadas para los 4 puntos
        public punto Punto1 { get; set; } = new punto();
        public punto Punto2 { get; set; } = new punto();
        public punto Punto3 { get; set; } = new punto();
        public punto Punto4 { get; set; } = new punto();

        // Métodos privados para obtener base y altura delegando al Punto
        private double ObtenerBase()
        {
            return Punto1.CalcularDistancia(Punto2);
        }

        private double ObtenerAltura()
        {
            return Punto2.CalcularDistancia(Punto3);
        }

        // Únicos dos métodos públicos expuestos
        public double CalcularArea()
        {
            return ObtenerBase() * ObtenerAltura();
        }

        public double CalcularPerimetro()
        {
            return 2 * (ObtenerBase() + ObtenerAltura());
        }
    }
}