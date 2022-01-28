using System;
using System.Globalization;
// entre com um numero e imprima a seguinte saida:
// numero, quadrado e raiz quadrada
namespace Exercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("digite um numero: ");
            var num = double.Parse(Console.ReadLine(), invC);

            var quadrado = num * num;
            var raizQuadrada = Math.Sqrt(num).ToString("F2", invC);

            Console.WriteLine($"numero: {num.ToString("F1", invC)}");
            Console.WriteLine($"quadrado: {quadrado.ToString("F1", invC)}");
            Console.WriteLine($"raiz quadrada: {raizQuadrada}");



        }
    }
}
