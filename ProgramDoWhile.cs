using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int basetr = 1, altura = 1, area;
            do
            {
                Console.WriteLine("Digite a base do triângulo: ");
                basetr = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite altura do triângulo: ");
                altura = int.Parse(Console.ReadLine());
                if (basetr > 0 && altura > 0)
                {
                    area = (basetr * altura) / 2;
                    Console.WriteLine("A base do triâgulo é: " + area);
                }
                else
                {
                    Console.WriteLine("Valores inválidos. A base e a altura devem ser maiores que zero.");
                }

            } while (true);
        }
    }
}