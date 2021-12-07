using System;
// Ler nome, endereço e telefone e imprimi-los
namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados();
        }
        static void Dados()
        {
            Console.Clear();
            Console.WriteLine("Entre com seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre com seu endereço: ");
            var endereco = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre com seu telefone: ");
            var telefone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine();
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine();
            Console.WriteLine($"Telefone: {telefone}");

        }


    }
}
