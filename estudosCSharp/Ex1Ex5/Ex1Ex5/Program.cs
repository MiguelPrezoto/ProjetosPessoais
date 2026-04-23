using System;

namespace Ex1Ex5 {
    class Program {
        static void Main(string[] args) {
            int idPeca1;
            int idPeca2;
            int qtddPeca1;
            int qtddPeca2;
            double vlrPeca1;
            double vlrPeca2;
            double totalPeca1;
            double totalPeca2;
            double vlrTotalCompra;

            Console.WriteLine("Digite o código da 1° peça: ");
            idPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a quantidade de peças a serem compradas: ");
            qtddPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, digite o valor de cada peça: ");
            vlrPeca1 = double.Parse(Console.ReadLine());

            totalPeca1 = vlrPeca1 * qtddPeca1;

            Console.WriteLine("Digite o código da 2° peça: ");
            idPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite a quantidade de peças a serem compradas: ");
            qtddPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por fim, digite o valor de cada peça: ");
            vlrPeca2 = double.Parse(Console.ReadLine());

            totalPeca2 = vlrPeca2 * qtddPeca2;

            vlrTotalCompra = totalPeca1 + totalPeca2;

            Console.WriteLine("Valor a pagar: " + vlrTotalCompra.ToString("F2"));
        }
    }
}