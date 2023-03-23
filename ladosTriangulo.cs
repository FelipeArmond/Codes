using System;

namespace listassequenciais {
    class program {
        static void Main(string[] args) 
        {
            int ladotriangulo1;
            int ladotriangulo2;
            int ladotriangulo3;

            Console.WriteLine("Digite o valor do primeiro lado do triângulo : ");
            ladotriangulo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado do triângulo : ");
            ladotriangulo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado do triângulo : ");
            ladotriangulo3 = int.Parse(Console.ReadLine());

            if (ladotriangulo1 == ladotriangulo2 && ladotriangulo2 == ladotriangulo3) 
            {
                Console.WriteLine("Esse é um triângulo equilátero");
            }

            else if (ladotriangulo1 != ladotriangulo2 && ladotriangulo2!= ladotriangulo3 && ladotriangulo3 != ladotriangulo1) 
            {
                Console.WriteLine("Esse é um triângulo escaleno");
            }

            else 
            {
                Console.WriteLine("Esse é um triângulo isoceles");
            }

        }
    }
}