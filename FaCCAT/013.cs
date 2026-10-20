using System;

namespace Ex12
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("Numero Positivo");
            }
            else
            {
                Console.WriteLine("Numero Negativo");
            }
        }
    }
}
