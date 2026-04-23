using System;

namespace Ex2Ex3 {
    class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int nMaior;
            int nMenor;

            if (n1 > n2) {
                nMaior = n1;
                nMenor = n2;
            } else {
                nMaior = n2;
                nMenor = n1;
            }

            if (nMaior % nMenor == 0) {
                Console.WriteLine("múltiplos");
            } else {
                Console.WriteLine("não múltiplos");
            }
        }
    }
}