using System;

namespace Ex2Ex6 {
    class Program {
        static void Main(string[] args) {
            double numeroInserido = double.Parse(Console.ReadLine());

            if (numeroInserido >= 0 && numeroInserido <= 25) {
                Console.WriteLine("intervalo 0/25");
            } else if (numeroInserido > 25 && numeroInserido <= 50) {
                Console.WriteLine("intervalo 25/50");
            } else if (numeroInserido > 50 && numeroInserido <= 75) {
                Console.WriteLine("intervalo 50/75");
            } else if (numeroInserido > 75 && numeroInserido <= 100) {
                Console.WriteLine("intervalo 75/100");
            } else {
                Console.WriteLine("fora de intervalo");
            }
        }
    }
}