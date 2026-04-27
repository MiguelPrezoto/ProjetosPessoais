using System;

namespace PessoaMaisVelha {
    class NomePessoaMaisVelha {
        static void Main(string[] args) {
            Pessoa pessoa1, pessoa2;
            
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite o nome e a idade da 1° pessoa: ");

            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome e a idade da 2° pessoa: ");

            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade) {
                Console.WriteLine(pessoa1.nome + " é a pessoa mais velha.");
            } else if (pessoa2.idade > pessoa1.idade) {
                Console.WriteLine(pessoa2.nome + " é a pessoa mais velha.");
            } else {
                Console.WriteLine("As duas pessoas, " + pessoa1.nome + " e " + pessoa2.nome + ", tem a mesma idade.");
            }
        }
    }
}