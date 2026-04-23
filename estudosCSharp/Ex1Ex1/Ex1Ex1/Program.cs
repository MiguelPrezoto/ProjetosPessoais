using System;

namespace Ex1Ex1 {
    class Program {
        static void Main(string[] args) {
            int n1;
            int n2;
            int res;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            res = n1 + n2;

            Console.WriteLine("O resultado da soma dos dois valores inseridos é: " + res);
        }
    }
}