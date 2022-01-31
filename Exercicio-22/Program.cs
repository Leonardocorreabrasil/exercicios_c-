using System;
using System.Globalization;
/*Em epocas de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas oferecendo desconto. faça um algoritmo que possa entrar com o valor de um produto e imprima o novo valor tendo em vista que o desconto foi de 9%*/
namespace Exercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("digite o valor do produto: ");
            var valorProduto = double.Parse(Console.ReadLine(), invC);

            var novoPreco = valorProduto * 0.91;

            Console.WriteLine($"preço com desconto {novoPreco.ToString("F2", invC)}");
        }
    }
}
