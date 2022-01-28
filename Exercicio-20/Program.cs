using System;
/*entrar com um nome e imprimir:
primeiro caractere
ultimo caractere
do primeiro ate o terceiro
quarto caractere
todos menos o primeiro
os dois ultimos*/
namespace Exercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um nome");
            var nome = Console.ReadLine();

            Console.WriteLine($"todo nome: {nome}");
            Console.WriteLine($"primeiro caractere: {nome[0]}");
            Console.WriteLine($"ultimo caractere: {nome[nome.Length - 1]}");
            Console.WriteLine($"do primeiro até o terceiro: {nome.Substring(0, 3)}");
            Console.WriteLine($"quarto caractere: {nome[3]}");
            Console.WriteLine($"todos menos o primeiro: {nome.Substring(1)}");
            Console.WriteLine($"os dois ultimos: {nome.Substring(6)}");

        }
    }
}
