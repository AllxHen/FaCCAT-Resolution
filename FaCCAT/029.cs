using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo valor B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite um terceiro valor C: ");
            int C = int.Parse(Console.ReadLine());

            

            if (A >= B + C)
            {
                Console.Write("Não foi possivel");
            }
            else if (B >= A + C)
            {
                Console.Write("Não foi possivel");
            }
            else if (C >= A + B)
            {
                Console.Write("Não foi possivel");
            }
            else
            {
                Console.Write("Forma um triangulo!");
            }
        }
    }
}
