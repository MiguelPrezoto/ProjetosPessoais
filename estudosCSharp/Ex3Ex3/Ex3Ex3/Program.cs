using System;
using System.Globalization;

namespace Ex3Ex3 {
    class Program {
        static void Main(string[] args) {
            int contadorAlcool = 0;
            int contadorGasolina = 0;
            int contadorDiesel = 0;

            Console.WriteLine("Digite o Código do produto (digite 0 para sair): ");
            int idDigitado = int.Parse(Console.ReadLine());

            while (idDigitado != 0) {
                if (idDigitado == 1) {
                    contadorAlcool++;
                    idDigitado = int.Parse(Console.ReadLine());
                } else if (idDigitado == 2) {
                    contadorGasolina++;
                    idDigitado = int.Parse(Console.ReadLine());
                } else if (idDigitado == 3) {
                    contadorDiesel++;
                    idDigitado = int.Parse(Console.ReadLine());
                } else {
                    Console.WriteLine("código inválido");
                    idDigitado = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Muito obrigado!");
            Console.WriteLine("Alcool: " + contadorAlcool);
            Console.WriteLine("Gasolina: " + contadorGasolina);
            Console.WriteLine("Diesel: " + contadorDiesel);
        }
    }
}