using System;

namespace lista_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("Qual o código do produto?");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 11:
                    Console.WriteLine("Arroz");
                break;
                case 12:
                    Console.WriteLine("Feijão");
                break;
                case 13:
                     Console.WriteLine("Batata");
                break;
                case 14:
                    Console.WriteLine("Carne");
                break;
                default:
                    Console.WriteLine("Código invalido");
                break;
            }
            
        }
    }
}
