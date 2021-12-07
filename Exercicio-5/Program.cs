using System;
// ler um numero inteiro e imprimir seu antecessor
namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero: ");
            var numero = Int32.Parse(Console.ReadLine());

            var antecessor = numero - 1;
            var sucessor = numero +1;

            Console.WriteLine($"o sucessor é {sucessor}, o antecessor é {antecessor}");

        }
    }
}
