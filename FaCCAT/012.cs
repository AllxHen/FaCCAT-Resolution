using System;

namespace Ex12
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.Write("É MAIOR QUE 10!");
            }
            else if (numero == 10)
            {
                Console.Write("É IGUAL A 10!");
            }
            else
            {
                Console.Write("É MENOR QUE 10!");
            }
        }
    }
}
