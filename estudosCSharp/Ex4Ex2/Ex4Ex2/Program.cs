using System;

namespace Ex4Ex2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade de números inteiros a serem digitados: ");
            int qtddInteiros = int.Parse(Console.ReadLine());
            int qtddDentro = 0;
            int qtddFora = 0;
            double numeroAtual;

            for (int i = 1; i <= qtddInteiros; i++) {
                numeroAtual = double.Parse(Console.ReadLine());
                if (numeroAtual >= 10 && numeroAtual <= 20) {
                    qtddDentro++;
                } else {
                    qtddFora++;
                }
            }

            Console.WriteLine("Dentro: " + qtddDentro);
            Console.WriteLine("Fora: " + qtddFora);
        }
    }
}