using System;
using System.Globalization;
/*antes de o racionamento de energia ser decretado, quase ninguem falava em quilowatts, mas, agora todos incorporaram essa palavra em seus vocabularios. sabendo-se qie 100 quilowatts de energia custa um setimo do salario minimo, fazer um algoritmo que receba o valordo salario minimo e a quantidade de quilowatts gsta por uma residencia e calcule. imporima:
o valor em reais de cada quilowatt
o valor em reais a ser pago
o novo valor a ser pago por essa residencia com um desconto de 10%*/

namespace Exercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {

            TelaInicial();
        }

        static void TelaInicial()
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            Console.Clear();
            Console.WriteLine("entre com um salario minimo:");
            var salarioMinimo = double.Parse(Console.ReadLine(), invC);
            Console.WriteLine("entre com a quantidade de quilowatt: ");
            var qtdeQuilowatt = double.Parse(Console.ReadLine(), invC);

            var preco = salarioMinimo / 700;
            var valorPreco = preco * qtdeQuilowatt;
            var valorDesconto = valorPreco * 0.9;

            Console.WriteLine($@"preço do quilowatt: {preco.ToString("F2", invC)}
                valor a ser pago: {valorPreco.ToString("F2", invC)}
                valor com desconto: {valorDesconto.ToString("F2", invC)}");
        }

    }
}
