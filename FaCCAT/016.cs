using System;
 
namespace Ex12

{

    internal class Ex12

    {

        static void Main(string[] args)

        {

            Console.Write("Digite o ano atual: ");

            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite ano que vc nasceu: ");

            int nasceu = int.Parse(Console.ReadLine());
 
            int verificar = ano - nasceu;
 
            if (verificar >= 16)

            {

                Console.Write("Você pode votar!");

            }

            else

            {

                Console.Write("Você não pode votar!");

            }

        }

    }

}
 
