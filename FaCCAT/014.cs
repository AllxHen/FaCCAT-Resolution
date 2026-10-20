using System;

namespace Ex12
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas maças compradas: ");
            int quantidade = int.Parse(Console.ReadLine());
            double maca = 1.30;
            if (quantidade >= 12)
            {
                maca = 1.00;
                Console.WriteLine($"Valor da unidade da maça:{maca}, Preço total:{maca * quantidade}R$");
            }
            else
            {
                Console.WriteLine($"Valor da unidade da maça:{maca}, Preço total:{maca * quantidade}R$");
            }
        }
    }
}
