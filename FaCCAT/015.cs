using System;

namespace Ex12
{
    internal class Ex12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota a1 do aluno: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota a2 do aluno: ");
            double a2 = double.Parse(Console.ReadLine());

            double mediaFinal = (a1 + a2)/ 2;
            
            if (mediaFinal >= 6)
            {
                Console.Write($"Aluno aprovado media:  {mediaFinal}");
            }
            else
            {
                Console.Write($"Aluno reprovado media: {mediaFinal} ");
            }

        }
    }
}
