using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade1
{
    internal class Program        //O exercício envolve calcular o fatorial de um número.
    {
        public static int Fatorial (int n)                     
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Fatorial(n - 1);
            

        }
        static void Main(string[] args)             
        {
            while (true)
            {
                
            Console.WriteLine("Digite o número que você deseja calcular o fatorial (digite -1 para encerrar o programa)");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0 || numero < -1 )
            {
                Console.WriteLine("Favor, insira um valor positivo");
            }
            else if (numero == -1)
            {
                Console.WriteLine("Programa encerrado");
                break;                   
            }
            else
            {
                Console.WriteLine(Fatorial(numero));
            }
            }
        }
    }
}
