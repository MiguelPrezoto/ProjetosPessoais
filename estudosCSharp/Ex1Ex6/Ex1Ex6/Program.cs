using System;

namespace Ex1Ex6 {
    class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double areaTriangulo = (a * c) / 2;

            double areaCirculo = pi * (Math.Pow(c, 2));

            double areaTrapezio = (a + b) * c / 2;

            double areaQuadrado = Math.Pow(b, 2);

            double areaRetangulo = a * b;

            Console.WriteLine("Área do triângulo: " + areaTriangulo.ToString("F3"));
            Console.WriteLine("Área do círculo: " + areaCirculo.ToString("F3"));
            Console.WriteLine("Área do trapézio: " + areaTrapezio.ToString("F3"));
            Console.WriteLine("Área do quadrado: " + areaQuadrado.ToString("F3"));
            Console.WriteLine("Área do retângulo: " + areaRetangulo.ToString("F3"));
        }
    }
}