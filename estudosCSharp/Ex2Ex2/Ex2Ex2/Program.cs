using System;

namespace Ex2Ex2 {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Ímpar");
            }
        }
    }
}