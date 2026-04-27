using ConsoleApp2;
using System;
using System.Globalization;

namespace ProblemaSemOrientacaoObj {
    class Program {
        static void Main(string[] args) {

            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do triângulo X: ");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y: ");
            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("MAIOR ÁREA: X");
            } else if (areaX < areaY) {
                Console.WriteLine("MAIOR ÁREA: Y");
            } else {
                Console.WriteLine("ÁREAS IGUAIS");
            }
        }
    }
}