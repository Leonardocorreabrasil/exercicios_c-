using System;

/*entrar com dois numero inteiros e imprimir a seguinte saida: 
 dividendo:
divisor:
quociente:
resto:*/

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre como dividendo: ");
            var dividendo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("entre como divisor: ");
            var divisor = Int32.Parse(Console.ReadLine());

            var resto = dividendo % divisor;
            var quociente = dividendo / divisor;

            Console.WriteLine($"dividendo: {dividendo}");
            Console.WriteLine($"divisor: {divisor}");
            Console.WriteLine($"quociente: {quociente}");
            Console.WriteLine($"resto: {resto}");

        }
    }
}
