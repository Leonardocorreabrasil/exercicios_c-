using System;
using System.Globalization;
/* efetuar o calculo do valor e uma prestação em atraso, utilizando a formula:
prestação = valor + (valor*(taxa/100)* tempo)*/
namespace Exercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite o valor da prestaççao: ");
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite a taxa: ");
            var taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite o tempo em meses: ");
            var tempo = int.Parse(Console.ReadLine());

            var prestacao = valor + (valor * (taxa / 100) * tempo);

            Console.WriteLine($"o valor da prestação em atraso é: {prestacao.ToString("F2", CultureInfo.InvariantCulture)};");
        }
    }
}
