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
            Console.Write("Digite um segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            if (valor1 == valor2 || valor2 == valor3 || valor1 == valor3)
            {
                Console.Write("Sem numeros repetidos (tente novamente)");
            }
            else if (valor1 > valor2 && valor1 > valor3)
            {
                Console.Write(valor1);
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.Write(valor2);
            }
            else if (valor3 > valor1 && valor3 > valor2)
            {
                Console.Write(valor3);
            }
        }
    }
}
