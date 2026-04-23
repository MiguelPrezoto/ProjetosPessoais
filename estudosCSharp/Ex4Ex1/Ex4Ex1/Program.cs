using System;

namespace Ex4Ex1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("digite o número: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numeroDigitado; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}