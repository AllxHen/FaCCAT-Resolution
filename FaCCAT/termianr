using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o litros de combustivel vendido: ");
            double litros = double.Parse(Console.ReadLine());
            Console.Write("Digite o tipo de combustivel: );
            char tipo = char.Parse(Console.ReadLine());

            double gasoAcima = (3.30 * 0.06) * litros;
            double alcoAcima = (2.90 * 0.05) * litros;

            switch (tipo)
            {
                case 'A':
                    Console.Write("Gasolina!");
                    if (litros > 20)
                    {
                        Console.Write(gasoAcima);
                    }
                    break;
                case 'G':
                    Console.Write("Alcool");
                    if (litros > 20)
                    {
                        Console.Write(alcoAcima);
                    }
                    break;
                    
            }
        }
    }
}  
