using System;
using System.Globalization;

namespace ExDeFixacao2 {
    class Program {
        static void Main(string[] args) {
            string nomeCompleto;
            int qtddQuartos;
            double precoProd;
            string[] dadosGerais;
            string ultimoNome;
            int idade;
            double altura;

            Console.WriteLine("Entre com seu nome completo: ");
            nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa? ");
            qtddQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (tudo na mesma linha): ");
            dadosGerais = Console.ReadLine().Split(' ');
            ultimoNome = dadosGerais[0];
            idade = int.Parse(dadosGerais[1]);
            altura = double.Parse(dadosGerais[2], CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("DADOS INSERIDOS:");
            Console.WriteLine("Nome Completo: " + nomeCompleto);
            Console.WriteLine("Quantidade de Quartos: " + qtddQuartos);
            Console.WriteLine("Preço do produto: " + precoProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Último nome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}