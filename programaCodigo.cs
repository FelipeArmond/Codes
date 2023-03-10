using System;

namespace Myprogram
{
    class program
    {
        static void Main(string[] args)
        {
            String codigo;

            Console.WriteLine("Digite o código do produto");
            codigo = (Console.ReadLine());

            if (codigo == "11" ) 
            {
                Console.WriteLine("Arroz");
            }
            else if (codigo == "12")
             {
                Console.WriteLine("Feijão");
            }
            else if (codigo == "13")
             {
                Console.WriteLine("Batata");
            }
            else if (codigo == "14") 
            {
                Console.WriteLine("Carne");
            }
            else {
                Console.WriteLine("Código invalido");
            }
        }
    }
}
