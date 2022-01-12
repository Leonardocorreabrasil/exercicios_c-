using System;
using System.Globalization;
// entrar com dois numeros reais e imrprimir a media aritmetica com a mensagem "média" antes do resultado

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {

            CultureInfo invC = CultureInfo.InvariantCulture;

            Console.WriteLine("digite a primeira nota: ");
            var nota1 = Double.Parse(Console.ReadLine(), invC);
            Console.WriteLine("digite a segunda nota: ");
            var nota2 = Double.Parse(Console.ReadLine(), invC);

            var media = (nota1 + nota2) / 2.0;

            Console.WriteLine($"média: {media.ToString("F1", invC)}");
        }
    }
}
