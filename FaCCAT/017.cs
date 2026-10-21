using System;

namespace Ex00
{
    internal class Ex00
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.Write("Numero Invalido! (Numero repetido)");
            }
            else if (n1 > n2)
            {
                Console.Write(n1);
            }
            else if (n2 > n1)
            {
                Console.Write(n2);
            }
        }
    }
}
