using System;
using System.Globalization;

// entrar com um angulo em graus e imprimir: seno, cosseno, tangente, secante, cossecante e cotangente deste angulo

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("digite um angulo em graus: "); ;
            var angulo = double.Parse(Console.ReadLine(), invC);

            var rang = angulo * Math.PI / 180.00;
            Console.WriteLine($"seno: {Math.Sin(rang).ToString("F2", invC)}");
            Console.WriteLine($"cosseno: {Math.Cos(rang).ToString("F2", invC)}");
            Console.WriteLine($"tangente: {Math.Tan(rang).ToString("F2", invC)}");
            Console.WriteLine($"cossecante: {Math.Cosh(rang).ToString("F2", invC)}");
            Console.WriteLine($"secante: {Math.Sinh(rang).ToString("F2", invC)}");
            Console.WriteLine($"cotangente: {Math.Cosh(rang).ToString("F2", invC)}");



        }
    }
}
