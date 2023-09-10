using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade1
{
    internal class Program        //O objetivo deste exercício é calcular a soma de um intervalo definido pelos valores x e y, com os valores ditados pelo usuário.
    {
        public static int Soma(int x, int y)
        {
            if (y == x)
            {
                return y;
            }
            return y + Soma(x, y - 1);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite o primeiro valor(ou 'sair' para encerrar o programa): ");
                string entrada = (Console.ReadLine());

                if (entrada.ToLower() == "sair")
                {
                    Console.WriteLine("Programa encerrado");
                    break;
                }
                if (!int.TryParse(entrada, out int valor1))
                {
                    Console.WriteLine("Entrada inválida. Favor inserir um número inteiro ou digitar 'sair'");
                    continue;
                }

                Console.WriteLine("Digite o segundo valor(deve ser maior que o segundo): ");
                int valor2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"A soma dos valores do intervalo entre {valor1} e {valor2} é: {Soma(valor1, valor2)}");
                if (valor2 < valor1)
                {
                    Console.WriteLine($"O valor informado deve ser maior que {valor1}");
                }
            }
        }
    }
}
