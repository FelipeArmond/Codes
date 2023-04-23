using System;

namespace Proram
{
    class Proram
    {
        static void Main(string[] args)
        {
           int numero = 9, multiplicado = 0;

           do
           {
                Console.WriteLine(" 9 x " + multiplicado  + "= " + numero * multiplicado);
                multiplicado++;

           } while (multiplicado <= 10);

        }
    }
}