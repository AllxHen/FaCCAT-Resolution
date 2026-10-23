using System;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salario fixo: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor das vendas: ");
            double vendas = double.Parse(Console.ReadLine());

            double comissao1 = 0.03;
            double comissao2 = 0.05;

            if (vendas <= 1500)
            {
                Console.Write($"Sua comissão foi de {comissao1 * 100}%. Salario total = {(comissao1 * vendas) + salario}");
            }
            else if (vendas > 1500)
            {
                Console.Write($"Sua comissão foi de {(comissao1 + comissao2) * 100}%. Salario total = {((comissao1 + comissao2) * vendas) + salario}");
            }
        }
    }
}
