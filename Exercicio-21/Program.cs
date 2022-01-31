using System;
/*entrar com nome e idade e imrprimir a saida*/
namespace Exercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("digite a idade: ");
            var idade = int.Parse(Console.ReadLine());


            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"idade: {idade}");
        }
    }
}
