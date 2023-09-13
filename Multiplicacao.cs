using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade1
{
    internal class Program        // Programa em C# que leia dois valores inteiros e imprima o resultado da multiplicaçãode um pelo outro.
    {
        public static int Multiplicacao(int multiplicando, int multiplicador)
        {
            if (multiplicando == 0)
            {
                return 0;
            }
            if (multiplicador == 1)
            {
                return multiplicando; 
            }
            return multiplicando + (Multiplicacao(multiplicando, multiplicador - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o multiplicando: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o multiplicador: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado: {Multiplicacao(num1, num2)}");

        }
    }
}
