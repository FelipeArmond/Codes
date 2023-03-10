using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          int intervaloanos;
          int anoatual;
          int anonasc;
          Console.Write("Qual o ano atual? ");
          anoatual=int.Parse(Console.ReadLine());
          Console.WriteLine("Qual seu ano de nascimento");
          anonasc=int.Parse(Console.ReadLine());
          intervaloanos = (anoatual - anonasc);

          if (intervaloanos >= 16 && intervaloanos < 18) {
            Console.WriteLine("Você possui uma maioridade civil ");
          } else if (intervaloanos >= 18) 
          {
            Console.WriteLine("Você já atingiu a maioridade penal ");
          }
          else if (intervaloanos < 16 ) 
          {
            Console.WriteLine("Você ainda não atingiu a maioridade civil");
          }
        }
    }
}

// pprograma  para  determinar  se  uma  pessoa  é  maior  ou  menor  de  idade. A maioridade civil é atingida quando a pessoa completa 16 anos. A maioridade penal é atingida quando a pessoa complete  18  anos. A  pessoa irá fornecer o ano atua  e o seu  ano  de  nascimento. O programa deverá imprimir se a pessoa já tem maioridade civil ou penal. 
// Felipe de Pinho Dias Armond
// 09/03/2023
