using System;
using System.Globalization;

namespace Ex1Ex3 {
    class Program {
        static void Main(string[] args) {
            int a, b, c, d;

            Console.WriteLine("Digite o valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de c: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de d: ");
            d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine("A diferença entre o produto de a*b e c*d é: " + diferenca);
        }
    }
}