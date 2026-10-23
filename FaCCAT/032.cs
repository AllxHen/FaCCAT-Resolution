using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha um valor para X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Escolha um valor para Y: ");
            int Y = int.Parse(Console.ReadLine());

            double Z = (X * Y) + 5;

            if (Z <= 0)
            {
                Console.Write($"Valor Z = {Z}");
                Console.ReadLine();
                Console.Write("Resposta = A");
            }
            else if (Z <= 100)
            {
                Console.Write($"Valor Z = {Z}");
                Console.ReadLine();
                Console.Write("Resposta = B");
            }
            else
            {
                Console.Write($"Valor Z = {Z}");
                Console.ReadLine();
                Console.Write("Resposta = C");
            }
        }
    }
}  
