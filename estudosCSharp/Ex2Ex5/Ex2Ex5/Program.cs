using System;

namespace Ex2Ex5 {
    class Program {
        static void Main(string[] args) {
            double precoCachorroQuente = 4.00;
            double precoXsalada = 4.50;
            double precoXbacon = 5.00;
            double precoTorrada = 2.00;
            double precoRefri = 1.50;

            int idCachorroQuente = 1;
            int idXsalada = 2;
            int idXbacon = 3;
            int idTorrada = 4;
            int idRefri = 5;

            int idDigitado = int.Parse(Console.ReadLine());
            int qtddProduto = int.Parse(Console.ReadLine());

            double precoTotal;

            if (idDigitado == idCachorroQuente) {
                precoTotal = precoCachorroQuente * qtddProduto;
                Console.WriteLine("Preço Total: R$" + precoTotal.ToString("F2"));
            } else if (idDigitado == idXsalada) {
                precoTotal = precoXsalada * qtddProduto;
                Console.WriteLine("Preço Total: R$" + precoTotal.ToString("F2"));
            } else if (idDigitado == idXbacon) {
                precoTotal = precoXbacon * qtddProduto;
                Console.WriteLine("Preço Total: R$" + precoTotal.ToString("F2"));
            } else if (idDigitado == idTorrada) {
                precoTotal = precoTorrada * qtddProduto;
                Console.WriteLine("Preço Total: R$" + precoTotal.ToString("F2"));
            } else if (idDigitado == idRefri) {
                precoTotal = precoRefri * qtddProduto;
                Console.WriteLine("Preço Total: R$" + precoTotal.ToString("F2"));
            } else {
                Console.WriteLine("ID indisponível");
                Environment.Exit(0);
            }
        }
    }
}