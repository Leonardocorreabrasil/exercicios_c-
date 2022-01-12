using System;
using System.Globalization;

// entrar com 4 numeros e imprimir a média ponderada,sabendo-se que os pesos são respectivamente: 1,2,3 e 4

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("entre com 1 numero");
            var num1 = Double.Parse(Console.ReadLine(), invC);
            Console.WriteLine("entre com 2 numero");
            var num2 = Double.Parse(Console.ReadLine(), invC);
            Console.WriteLine("entre com 3 numero");
            var num3 = Double.Parse(Console.ReadLine(), invC);
            Console.WriteLine("entre com 4 numero");
            var num4 = Double.Parse(Console.ReadLine(), invC);

            var mediaPonderada = (num1 * 1 + num2 * 2 + num3 * 3 + num4 * 4.0);


            Console.WriteLine($"media ponderada:  {mediaPonderada.ToString("F1", invC)}");

        }
    }
}
