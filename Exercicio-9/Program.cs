using System;

// ler dois numeros inteiros e imprimnir o produto
namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero: ");
            var num1 = Console.ReadLine();
            Console.WriteLine("entre com outro numero: ");
            var num2 = Console.ReadLine();

            var produto = Int32.Parse(num1) * Int32.Parse(num2);

            Console.WriteLine($"produto: {produto}");

        }
    }
}
