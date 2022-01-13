using System;
using System.Globalization;
//entrar com um nuemro e imprimir o lagaritmo desse nuemro na base 10
namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("entre com o logaritmando: ");
            var num = double.Parse(Console.ReadLine(), invC);

            var logaritmo = Math.Log10(num).ToString("F1", invC);
            Console.WriteLine($"logaritmo: {logaritmo}");

        }
    }
}
