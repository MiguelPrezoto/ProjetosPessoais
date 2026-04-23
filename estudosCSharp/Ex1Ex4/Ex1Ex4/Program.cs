using System;
using System.Globalization;

namespace Ex1Ex4 {
    class Program {
        static void Main(string[] args) {
            int idFuncionario;
            double horasTrabalhadas;
            double valorPorHora;
            double salario;

            idFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = double.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine());
            salario = valorPorHora * horasTrabalhadas;

            Console.WriteLine("ID Funcionário: " + idFuncionario);
            Console.WriteLine("Salário: " + salario);

        }
    }
}