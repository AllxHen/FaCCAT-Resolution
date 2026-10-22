using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite seu Sexo: (M/F): ");
            char sexo = char.Parse(Console.ReadLine());

            double pesoMasc = 72.7;
            double pesoFem = 62.1;

            if (sexo == 'M')
            {
                Console.Write($"Ola! {nome} Seu peso ideal masculino é: {(int)(pesoMasc * altura) - 58}KG");
            }
            else if (sexo == 'F')
            {
                Console.Write($"Ola! {nome} Seu peso ideal feminino é: {(int)(pesoFem * altura) - 44.7}KG");
            }
        }
    }
}
