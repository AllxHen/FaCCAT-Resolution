using System;

namespace Ex00
{
    internal class Ex00
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            Console.Write($"Numero 1: {n1}, Numero 2: {n2}");
            Console.ReadLine();
            Console.Write("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 != 10 && numero2 != 20)
            {
                Console.WriteLine($"Numero validos: A:{numero1}, B:{numero2}");
            }
            else
            {
                Console.WriteLine("Numero invalido (Igual ao numero existente)");
            }
        }
    }
}
