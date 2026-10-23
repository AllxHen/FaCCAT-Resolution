using System;
using System.Reflection.PortableExecutable;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do primeiro time: ");
            string time1 = Console.ReadLine();

            Console.Write("Digite o nome do segundo time: ");
            string time2 = Console.ReadLine();

            Console.Write($"Digite numero de gols marcado do time {time1}: ");
            int gols1 = int.Parse(Console.ReadLine());

            Console.Write($"Digite numero de gols marcado do time {time2}: ");
            int gols2 = int.Parse(Console.ReadLine());

            if (gols1 == gols2)
            {
                Console.Write($"Time: {time1} e {time2} Empataram!");
            }
            else if (gols1 > gols2)
            {
                Console.Write($"Time: {time1} GANHOUU!! GOLS: {gols1}");
            }
            else if (gols2 > gols1)
            {
                Console.Write($"Time: {time1} GANHOUUU!! GOLS: {gols2}");
            }

        }
    }
}
