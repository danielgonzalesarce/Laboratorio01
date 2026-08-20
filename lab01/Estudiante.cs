using System;
using System.Collections.Generic;
using System.Text;

namespace lab01
{
    public class Estudiante
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public double Nota { get; set; }

        public string evaluarAprobacion()
        {
            if (Nota > 11)
            {
                return "Aprobado";
            }
            else
            {
                return "Desaprobado";
            }
        }
    }
}