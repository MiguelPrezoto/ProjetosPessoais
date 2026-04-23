using System;
using System.Globalization;

namespace Ex1Ex2 {
    class Program {
        static void Main(string[] args) {
            double pi = 3.14159;
            double raio;
            double area;

            Console.WriteLine("Digite o raio do círculo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}