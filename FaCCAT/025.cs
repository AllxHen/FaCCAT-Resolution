using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());
            
            if (valor >= 0)
            {
                Console.Write("Valor positvo!");
            }
            else
            {
                Console.Write("Valor Negativo");
            }
        }
    }
}
