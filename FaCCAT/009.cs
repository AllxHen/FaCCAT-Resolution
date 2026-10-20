using System;

namespace Ex10
{
    internal class Ex10
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salario fixo do mes: ");
            int salario = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor por carros vendidos: ");
            int valorCarros = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de carros vendidos: ");
            int carros = int.Parse(Console.ReadLine());

            double comissao = 0.05 * valorCarros * carros;
            double comissaoCarros = valorCarros * 0.05;

            Console.Write($"Carros vendidos {carros}, valor total das vendas: {valorCarros*carros}, Salario fixo: {salario}, Valor da comissao por carros vendidos: {comissaoCarros}, Salario final: {salario + comissao}");

        }
    }
}




























//santander
//aprenda mais mec
