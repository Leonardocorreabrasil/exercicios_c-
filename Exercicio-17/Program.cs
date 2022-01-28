using System;
using System.Globalization;
/* fazer um algoritmo que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1%*/
namespace Exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("digite saldo: ");
            var saldo = double.Parse(Console.ReadLine(), invC);

            var novoSaldo = saldo * 1.01;
            Console.WriteLine($"novo saldo: {novoSaldo.ToString("F2", invC)}");
        }
    }
}
