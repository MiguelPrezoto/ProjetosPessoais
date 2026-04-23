using System;
using System.Globalization;

namespace Ex3Ex1 {
    class Program {
        static void Main(string[] args) {

            int senhaInserida = int.Parse(Console.ReadLine());

            while (senhaInserida != 2002) {
                Console.WriteLine("Senha invalida");
                senhaInserida = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}