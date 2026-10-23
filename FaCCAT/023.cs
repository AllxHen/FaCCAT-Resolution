using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero da conta do cliente: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Digite o saldo da conta do cliente: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o quanto de debito você tem: ");
            double debito = double.Parse(Console.ReadLine());

            Console.Write("Digite o quanto de credito você tem: ");
            double credito = double.Parse(Console.ReadLine());

            double saldoAtual = saldo - debito + credito;

            if (saldoAtual >= 0)
            {
                Console.Write($"Numero da conta: {conta}N° com Saldo Positivo!");
            }
            else
            {
                Console.Write($"Numero da conta: {conta}N° com Saldo Negativo!");
            }
           
        }
    }
}
