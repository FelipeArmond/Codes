using System;
class Program {
    static void Main(string[] args) {
       int totalprestacoes;
        int prestacoespagas;
        float valoratual;
        float saldodevedor;
        Console.WriteLine("Qual o número de prestações do consórcio?");
        while(!int.TryParse(Console.ReadLine(), out totalprestacoes)){
            Console.WriteLine("Por favor. Insira um valor numérico");
        }
        Console.WriteLine("Qual o número de prestações pagas?");
        while(!int.TryParse(Console.ReadLine(), out prestacoespagas)){
            Console.WriteLine("Por favor. Insira um valor numérico");
        }
        Console.WriteLine("Qual o valor atual da prestação?");
        while(!float.TryParse(Console.ReadLine(), out valoratual)){
            Console.WriteLine("Por favor. Insira um valor numérico");
        }
        saldodevedor = valoratual * (totalprestacoes - prestacoespagas);
        Console.WriteLine("O saldo devedor atual é de R$" + saldodevedor);
    }
}

// Felipe de Pinho Dias Armond
// Aula 2
// 04/03/2023
// Descrição: programa que lê o número total de prestações de um consórcio, o total de prestações pagas e o valor atual da prestação. O código calcula e apresenta o saldo devedor atual. 


    

