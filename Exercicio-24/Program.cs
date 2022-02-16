using System;
using System.Globalization;
/*Efetuar o calculo da quantidade de litros de combustiveis gastos em um viegem, sabendo-se qiue o carro faze=z 12 km coom um litro. deverao ser fornecidos o tempo gasto na viagem e a velocidade média */
namespace Exercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("qual o tempo de viagem? ");
            var tempoViagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("qual a velocidade média de viagem? ");
            var velocidadeMedia = int.Parse(Console.ReadLine());

            var distancia = tempoViagem * velocidadeMedia;

            var litrosUsados = distancia / 12;


            Console.WriteLine($"velocidade média: {velocidadeMedia} Km/h");
            Console.WriteLine($"tempo de viagem: {tempoViagem.ToString("0.00", CultureInfo.CreateSpecificCulture("en-US"))}");
            Console.WriteLine($"distancia percorrida: {distancia.ToString("F0")} Km");
            Console.WriteLine($"quantidade de litros utilizados: {litrosUsados.ToString("F1", CultureInfo.CreateSpecificCulture("en-US"))} litros ");
        }


    }
}
