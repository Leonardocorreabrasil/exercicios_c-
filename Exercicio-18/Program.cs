using System;
/*entrar com um numero no formato CDU e imprimir invertido: UDC (exemplo: 123, sairá 321) o numero devera ser armazenado em outra variavel antes de ser impresso*/
namespace Exercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero de 3 digitos: ");
            var num = int.Parse(Console.ReadLine());

            var c = num / 100;
            var d = num % 100 / 10;
            var u = num % 10;

            var num1 = u * 100 + d * 10 + c;

            Console.WriteLine($"numero: {num}");
            Console.WriteLine($"invertido: {num1}");
        }
    }
}