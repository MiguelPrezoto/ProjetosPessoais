using System;

namespace Ex2Ex4 {
    class Program {
        static void Main(string[] args) {
            int inicioJogo = int.Parse(Console.ReadLine());
            int fimJogo = int.Parse(Console.ReadLine());
            int duracaoJogo;

            if (inicioJogo == fimJogo) {
                duracaoJogo = 24;
                Console.WriteLine("Jogo durou " + duracaoJogo + "h");
            } else if (inicioJogo < fimJogo) {
                duracaoJogo = (fimJogo - inicioJogo);
                Console.WriteLine("Jogo durou " + duracaoJogo + "h");
            } else {
                duracaoJogo = (24 - inicioJogo) + fimJogo;
                Console.WriteLine("Jogo durou " + duracaoJogo + "h");
            }
        }
    }
}