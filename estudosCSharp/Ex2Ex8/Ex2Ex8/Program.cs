using System;

namespace Ex2Ex8 {
    class Program {
        static void Main(string[] args) {
            double renda = double.Parse(Console.ReadLine());
            double imposto = 0.0;

            if (renda <= 2000) {
                Console.WriteLine("Isento");
            } else if (renda <= 3000) {
                imposto = (renda - 2000) * 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            } else if (renda <= 4500) {
                imposto = (1000 * 0.08) + ((renda - 3000) * 0.18);
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            } else {
                imposto = (1000 * 0.08) + (1500 * 0.18) + ((renda - 4500) * 0.28);
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }
        }
    }
}