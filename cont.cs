using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, cont = 0, somapar = 0, somaimpar = 0;

            do
            {
                Console.WriteLine("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine());


                if (numero % 2 == 0)
                {
                    somapar += numero;
                }
                else
                {
                    somaimpar += numero;
                }
                cont++;

            } while (cont < 10);

            Console.WriteLine("A soma dos números pares é: " + somapar);
            Console.WriteLine("A soma dos números ímpares é: " + somaimpar);
        }
    }
}