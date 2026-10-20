using System;

namespace Ex12
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota de matematica: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota de portugues: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota de ingles: ");
            int n3 = int.Parse(Console.ReadLine());

            double mediaFinal = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
            Console.Write($"Media final foi: {mediaFinal}");
        }
    }
}
