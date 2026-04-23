using System;

namespace Ex2Ex1 {
    class Program {
        static void Main(string[] args) {
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0) {
                Console.WriteLine("Positivo");
            } else {
                Console.WriteLine("Negativo");
            }
        }
    }
}