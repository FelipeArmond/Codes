using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int soma = 0, contador = 1, media, maiornum = 0, menornum = int.MaxValue, impar = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
                media = soma / contador;

                if (numero > maiornum)
                {
                    maiornum = numero;
                }
                if (numero < menornum)
                {
                    menornum = numero;
                }
                if (numero % 2 == 1)
                {
                    impar++;
                }

                contador++;

            } while (numero != 30000);

            Console.WriteLine("A soma dos números digitados é: " + soma);
            Console.WriteLine("A quantidade dos números digitados é: " + (contador - 1));
            Console.WriteLine("A média dos números digitados é : " + media);
            Console.WriteLine("O maior número digitado é: " + maiornum);
            Console.WriteLine("O menor número digitado é: " + menornum);
            Console.WriteLine("A porcentagem dos números ímpares entre todos os números digitados é de " + (impar * 100.0 / (contador - 1)) + "%");

        }
    }
}