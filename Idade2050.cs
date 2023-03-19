using System;

namespace Myprogramm
{
    class programm
    {
        static void Main(string [] args) 
        {
            int ano_nascimento;
            int anoatual;
            int idade;
            int anosem2050;

            Console.WriteLine("Qual o ano de nascimento do indivíduo? ");
            ano_nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o ano atual? ");
            anoatual = int.Parse(Console.ReadLine());

            idade = anoatual - ano_nascimento;
            anosem2050 = 2050 - ano_nascimento;

            Console.WriteLine("A idade da pessoa é: " + idade);
            Console.WriteLine("Essa pessoa terá " + anosem2050 + "anos em 2050");

        }
    }
}
