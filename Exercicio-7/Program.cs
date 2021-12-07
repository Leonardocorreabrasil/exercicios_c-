using System;
// ler dois numero inteiros e imprimir  asoma. antes do resultado, deverá aparecer a mensagem: soma
namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("entre com outro numero: ");
            var numero2 = int.Parse(Console.ReadLine());

            var soma = numero1 + numero2;

            Console.WriteLine($"soma: {soma}");
        }
    }
}
