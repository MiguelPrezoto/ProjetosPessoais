using System;

namespace MediaSalarial {
    class Program {
       static void Main(string[] args) {
            Funcionario func1, func2;
            double mediaSalario;

            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Digite o nome do 1° funcionário: ");
            func1.nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");
            func1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do 2° funcionário: ");
            func2.nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");

            func2.salario = double.Parse(Console.ReadLine());

            mediaSalario = (func1.salario + func2.salario) / 2;

            Console.WriteLine("Salário médio dos funcionários: " + mediaSalario);
        }
    }
}