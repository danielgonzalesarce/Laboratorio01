using System;
using System.Collections.Generic;
using System.Text;
using lab01;

// // --- TRABAJADORES ---
// Trabajador trabajador = new Trabajador();
// trabajador.Nombres = "Hugo Felipe";
// trabajador.Apellidos = "Torrico Márquez";
// trabajador.Sueldo = 5000;

// Trabajador trabajador1 = new Trabajador
// {
//     Nombres = "Juan José",
//     Apellidos = "Torrico Márquez",
//     Sueldo = 10000
// };

// Console.WriteLine("El sueldo neto es " + trabajador.calcularSueldoNeto());
// Console.WriteLine("El sueldo neto es " + trabajador1.calcularSueldoNeto());

// // --- ESTUDIANTES ---
// Estudiante estudiante = new Estudiante();
// estudiante.Nombres = "Carlos";
// estudiante.Apellidos = "Pérez";
// estudiante.Nota = 16;

// Estudiante estudiante1 = new Estudiante
// {
//     Nombres = "Ana",
//     Apellidos = "Gómez",
//     Nota = 12
// };

// Console.WriteLine("El estudiante está " + estudiante.evaluarAprobacion());
// Console.WriteLine("El estudiante está " + estudiante1.evaluarAprobacion());

// // --- RECTÁNGULOS ---
// Rectangulo rectangulo = new Rectangulo();
// rectangulo.Base = 5;
// rectangulo.Altura = 10;

// Rectangulo rectangulo1 = new Rectangulo
// {
//     Base = 4,
//     Altura = 8
// };

// Console.WriteLine("El área del rectángulo es " + rectangulo.calcularArea());
// Console.WriteLine("El perímetro del rectángulo es " + rectangulo.calcularPerimetro());
// Console.WriteLine("El área del rectángulo 1 es " + rectangulo1.calcularArea());
// Console.WriteLine("El perímetro del rectángulo 1 es " + rectangulo1.calcularPerimetro());

// --- RECTÁNGULOS POR COORDENADAS ---
RectanguloCoordenadas rectanguloCoord = new RectanguloCoordenadas
{
    Punto1 = new punto { X = 0, Y = 0 },
    Punto2 = new punto { X = 5, Y = 0 },
    Punto3 = new punto { X = 5, Y = 10 },
    Punto4 = new punto { X = 0, Y = 10 }
};

Console.WriteLine("El área del rectángulo por coordenadas es : " + rectanguloCoord.CalcularArea());
Console.WriteLine("El perímetro del rectángulo por coordenadas es : " + rectanguloCoord.CalcularPerimetro());

Console.Read();