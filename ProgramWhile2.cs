using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao = 0, imposto = 1, novosalario = 0, classificacao = 0, salario = 1, porcentagem = 1;

            Console.WriteLine("1. Imposto");
            Console.WriteLine("2. Novo salário");
            Console.WriteLine("3. Classificação");
            Console.WriteLine("4. Finalizar o programa");

            while (true)
            {
                Console.WriteLine("Digite a opcao desejada: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {

                    Console.WriteLine("Digite o valor do salário: ");
                    salario = int.Parse(Console.ReadLine());
                    if (salario < 1000)
                    {
                        Console.WriteLine("O imposto será de: R$" + ((salario * 5) / 100).ToString("N2"));
                    }
                    else if (salario >= 1000 && salario < 2000)
                    {
                        Console.WriteLine("O imposto será de: R$" + ((salario * 10) / 100).ToString("N2"));
                    }
                    else
                    {
                        Console.WriteLine("O imposto será de: R$" + ((salario * 15) / 100).ToString("N2"));
                    }
                }

                if (opcao == 2)
                {
                    Console.WriteLine("Digite o valor do salário: ");
                    salario = int.Parse(Console.ReadLine());
                    if (salario > 2000)
                    {
                        Console.WriteLine("O novo salário será de: R$" + (salario + 25).ToString("N2"));
                    }
                    else if (salario >= 1500 && salario <= 2000)
                    {
                        Console.WriteLine("O novo salário será de: R$" + (salario + 50).ToString("N2"));
                    }
                    else if (salario >= 1000 && salario < 1500)
                    {
                        Console.WriteLine("O novo salário será de: R$" + (salario + 75).ToString("N2"));
                    }
                    else
                    {
                        Console.WriteLine("O novo salário será de: R$" + (salario + 1000).ToString("N2"));
                    }
                }
                if (opcao == 3)
                {
                    Console.WriteLine("Digite o valor do salário: ");
                    salario = int.Parse(Console.ReadLine());
                    if (salario < 1000)
                    {
                        Console.WriteLine("Classificação: Mal remunerado");
                    }
                    else
                    {
                        Console.WriteLine("Classificação: Bem remunerado");

                    }
                }
                else if (opcao == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, favor inserir números entre 1 e 4.");
                    continue;
                }
            }

        }
    }
}