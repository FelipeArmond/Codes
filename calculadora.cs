using System;

namespace Myprogram 
{
    class program
    {
        static void Main(string[] args) 
        {
            int numero1;
            int numero2;
            String sinal;
            int soma;
            int multiplicacao;
            int subtracao;
            double divisao;

            Console.WriteLine("Digite a operação numérica:");
            (numero1) = int.Parse(Console.ReadLine());
            sinal = Console.ReadLine();
            (numero2) = int.Parse(Console.ReadLine());
           

            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            multiplicacao = numero1 * numero2;
            divisao = numero1 / numero2;
            
            switch (sinal)
            {
                case "+" :
                Console.WriteLine(soma);
                break;
                case "-" :
                Console.WriteLine(subtracao);
                break;
                case "x" :
                Console.WriteLine(multiplicacao);
                break;        
                default:
                case "/" :
                Console.WriteLine(multiplicacao);
                break;
                Console.WriteLine("Operador inválido");
                break;
            }             
        }
    }
}
    
