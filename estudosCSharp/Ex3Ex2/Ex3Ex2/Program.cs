using System;
using System.Globalization;

namespace Ex3Ex2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite as coordenadas (X, Y): ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            while (n1 != 0 || n2 != 0) {
                if (n1 > 0 && n2 > 0) {
                    Console.WriteLine("Primeiro Quadrante");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                } else if (n1 < 0 && n2 > 0) {
                    Console.WriteLine("Segundo Quadrante");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                } else if (n1 < 0 && n2 < 0) {
                    Console.WriteLine("Terceiro Quadrante");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                } else if (n1 > 0 && n2 < 0) {
                    Console.WriteLine("Quarto Quadrante");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                }
            } 
        }
    }
}