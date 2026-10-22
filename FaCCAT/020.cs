using System;

namespace Ex23
{
    internal class Ex23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as horas de trabalho no semanal: ");
            double hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quanto você ganha por hora: ");
            double valorHora = double.Parse(Console.ReadLine());

            double calcularSalario = valorHora * 160;
            double horaExtra = (calcularSalario * 0.5) + calcularSalario;
            

            if (hora > 40)
            {
                Console.Write($"Seu salario foi: {horaExtra}. Você recebeu hora extra!");
            }
            else if (hora <= 40)
            {
                Console.Write($"Seu salario foi: {calcularSalario}. Sem hora extra!");
            }

        }
    }
}
