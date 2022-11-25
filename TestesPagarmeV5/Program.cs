using System;
using TestesPagarmeV5.Services;

namespace TestesPagarmeV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção: 1-Boleto 2-Cartão de crédito");

            var opcao = Console.ReadLine();

            var pagarmeService = new PagarmeService();

            if (opcao == "1")
                pagarmeService.CreateBilletTransaction();
            else if (opcao == "2")
                pagarmeService.CreateCreditCardTransaction();

            Console.ReadKey();
        }
    }
}
