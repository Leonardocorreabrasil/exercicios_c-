using System;
using System.Globalization;
/*criar um algoritmo que efetue o calculo do salario liquido de um professor. os dados fornecidos serão: valor da hora aula, numero de aulas dadasno mes e percentual de desconto do inss*/
namespace Exercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.WriteLine("horas trabalhadas: ");
            var horaTrabalhada = int.Parse(Console.ReadLine());
            Console.WriteLine("valor da hora aula: ");
            var valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("percentual desconto: ");
            var percentual = double.Parse(Console.ReadLine());

            var salarioBruto = horaTrabalhada * valorHora;
            var valorDesconto = (percentual / 100) * salarioBruto;
            var salarioLiquido = salarioBruto - valorDesconto;

            Console.WriteLine($"salario-liquido: {salarioLiquido}");
        }
    }
}
