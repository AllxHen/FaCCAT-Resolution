using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos estouque atual: ");
            int atual = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade maxima de produtos em estoque: ");
            int maxima = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade minima de produtos em estoque: ");
            int minima = int.Parse(Console.ReadLine());

            double media = (maxima + minima) / 2;

            if (atual >= media)
            {
                Console.Write("Não efetuar compra!");
            }
            else
            {
                Console.Write("Efetuar compra!");
            }
   
        }
    }
}
