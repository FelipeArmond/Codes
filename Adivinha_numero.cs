using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numeroAleatorio = random.Next(1, 11);

            Console.WriteLine("Tente adivinhar o número gerado aleatoriamente");

            Console.WriteLine(numeroAleatorio);
          
            int numero = 0;

            while (numeroAleatorio != numero)
            {              
               
                numero = int.Parse(Console.ReadLine());
                
                if (numero == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                }
                else if (numero < numeroAleatorio)
                {
                    Console.WriteLine("Tente um número maior");
                }
                else
                {
                    Console.WriteLine("Tente um número menor");
                }
            }
        }
    }
}
