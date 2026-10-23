using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.Write("Numeros iguais");
            }
            else if (valor1 > valor2)
            {
                Console.Write("Primeiro é Maior");
            }
            else if (valor2 > valor1)
            {
                Console.Write("Segundo é Maior");
            }
        }
    }
}
