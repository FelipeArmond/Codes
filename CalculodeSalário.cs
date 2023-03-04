using System;
class Program {
    static void Main(string[] args) {
       string numeroFunc;
       float ht;
       float vh;
       float salario;
       int diasemana;
       int diames;
       Console.WriteLine("Qual o seu número de funcionário?");
       numeroFunc=Console.ReadLine();
       Console.WriteLine("Digite a quantidade de horas trabalhadas por dia");
       ht=float.Parse(Console.ReadLine());
       Console.WriteLine("Qual o valor recebido por hora?");
       vh=float.Parse(Console.ReadLine());
       Console.WriteLine("Quantos dias por semana você trabalha?");
       diasemana=int.Parse(Console.ReadLine());
       diames= diasemana * 4;
       salario=vh*ht*diames;
       Console.WriteLine("O salário do funcionário é de " + salario);
    }
}

    

