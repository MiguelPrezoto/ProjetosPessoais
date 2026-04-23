using System;

namespace Ex2Ex7 {
    class Program {
        static void Main(string[] args) {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            if (n1 == 0 && n2 == 0) {
                Console.WriteLine("Origem");
            } else if (n1 == 0 && n2 != 0) {
                Console.WriteLine("Eixo Y");
            } else if (n1 != 0 && n2 == 0) {
                Console.WriteLine("Eixo X");
            } else if (n1 > 0 && n2 > 0) {
                Console.WriteLine("Q1");
            } else if (n1 < 0 && n2 > 0) {
                Console.WriteLine("Q2");
            } else if (n1 < 0 && n2 < 0) {
                Console.WriteLine("Q3");
            } else if (n1 > 0 && n2 < 0) {
                Console.WriteLine("Q4");
            }
        }
    }
}