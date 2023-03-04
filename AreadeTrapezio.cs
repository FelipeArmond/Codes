using System;
class Program {
    static void Main(string[] args) {
               float basemaior;
        float basemenor;
        float altura;
        float A;
        Console.WriteLine("Qual o valor da base maior?");
        while (!float.TryParse(Console.ReadLine(), out basemaior))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico");
        }
        Console.WriteLine("Qual o valor da base menor?");
        while(!float.TryParse(Console.ReadLine(), out basemenor))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico");
        }
        Console.WriteLine("Qual a altura?");
        while(!float.TryParse(Console.ReadLine(), out altura)){
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico");
        }
        A = ((basemaior + basemenor) * altura)/2;
        Console.WriteLine("A área do trapézio é de " + A);
    }
}


    

