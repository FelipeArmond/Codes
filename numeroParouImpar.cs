using System;

namespace Myprogram 
{
    class program
    {
        static void Main(string[] args) 
        {
           int numero;
           
           Console.WriteLine("Digite um número inteiro:" );
           numero = int.Parse(Console.ReadLine());

           if (numero % 2 == 0)
           {
            Console.WriteLine("Esse é um número par");
           }
           else 
           {
            Console.WriteLine("Esse é um número impar");
           }
        }
    }
}
