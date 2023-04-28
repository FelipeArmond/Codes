using System;

class Program
{
    static void Main(string[] args)
    {
        String codigo;
        double valor = 0, V = 0, P = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o código para transação (V/P): ");
            codigo = (Console.ReadLine());
            Console.WriteLine("Qual o valor da transação? ");
            valor = double.Parse(Console.ReadLine());

            if (codigo == "V" || codigo == "v")
            {
                V += valor;
            }
            if (codigo == "p" || codigo == "P")
            {
                P += valor;
            }

        }
        Console.WriteLine("O valor total das compras a vista foi de : R$" + (V - (V * 0.1)));
        Console.WriteLine("O valor total de compras a prazo foi de: R$" + P);
    }
}
