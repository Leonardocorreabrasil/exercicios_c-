using System;
using System.Globalization;
// ler um numero real e imprimir a terça parte deste nuemro
namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("entre com um numero com ponto: ");
            double num = double.Parse(Console.ReadLine(), invC);
            var result = num / 3.0;
            Console.WriteLine(result.ToString("F1", invC));



        }
    }
}
