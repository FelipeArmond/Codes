using System;

namespace Myprogramm
{
    class programm
    {
        static void Main(string [] args) 
        {
            int numeropositivo;

            Console.WriteLine("Digite um número positivo maior que zero: ");
            numeropositivo = int.Parse(Console.ReadLine());
            if (numeropositivo < 0 ) {
                Console.WriteLine("Favor inserir um número positivo");
            }
            else {
                Console.WriteLine("O número digitado ao quadrado é: " + Math.Pow(numeropositivo,2));
                Console.WriteLine("O número digitado ao cubo é: " +Math.Pow(numeropositivo,3));
                Console.WriteLine("A raiz quadrada do número digitado é: " + Math.Sqrt(numeropositivo));
                Console.WriteLine("A raiz cúbica do número digitado é: " + Math.Pow(numeropositivo, 1.0/3.0));
            }
        }
    }
}
