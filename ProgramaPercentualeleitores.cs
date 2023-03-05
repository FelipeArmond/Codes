using System;

class Program {
    static void Main(string[] args) {
       int numeroeleitores;
       int votobranco;
       int votonulo;
       int votovalido;
       
       Console.WriteLine("Digite o número total de eleitores do município");
       while(!int.TryParse(Console.ReadLine(), out numeroeleitores)){
           Console.WriteLine("Por favor, insira um valor numérico");
       }

       Console.WriteLine("Digite o número de votos brancos");
       while(!int.TryParse(Console.ReadLine(), out votobranco)){
           Console.WriteLine("Por favor, insira um valor numérico");
       }

       Console.WriteLine("Digite o número de votos nulos");
       while(!int.TryParse(Console.ReadLine(), out votonulo)){
           Console.WriteLine("Por favor, insira um valor numérico");
       }

       Console.WriteLine("Digite o número de votos válidos");
       while(!int.TryParse(Console.ReadLine(), out votovalido)){
           Console.WriteLine("Por favor, insira um valor numérico");
       }
       
       int totalvotos = votobranco + votonulo + votovalido;
       float percentualbrancos = ((float)votobranco / totalvotos) * 100;
       float percentualnulos = ((float)votonulo / totalvotos) * 100;
       float percentualvalidos = ((float)votovalido / totalvotos) * 100;
       
       Console.WriteLine("O número de votos brancos é de: " + votobranco);
       Console.WriteLine("O número de votos nulos é de: " + votonulo);
       Console.WriteLine("O número de votos válidos é de: " + votovalido);
       Console.WriteLine("O percentual de votos brancos é de: " + percentualbrancos.ToString("F2") + "%");
       Console.WriteLine("O percentual de votos nulos é de: " + percentualnulos.ToString("F2") + "%");
       Console.WriteLine("O percentual de votos válidos é de: " + percentualvalidos.ToString("F2") + "%");
    }
}

// Felipe de Pinho Dias Armond
// Aula 2
// 04/03/2023
// Descrição: programa para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcula e escreve o percentual que cada um representa em relação ao total de eleitores. 

    

