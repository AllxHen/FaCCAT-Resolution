using System;

namespace Ex11
{
    internal class Ex10
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Fº: ");
            int fahrenheit = int.Parse(Console.ReadLine());
            double celsius = (5*(fahrenheit- 32))/9;
            Console.Write($"O valor convertido em Cº é: {celsius}");
        }
    }
}
