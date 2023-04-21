using System;

class Program
{
    static void Main(string[] args)
    {
        int idade = 1, sexofem = 0, sexomasc = 0, xpsim = 0, xpnao = 0, homemxp = 0, somaIdadeHomensxp = 0, idade45 = 0, idade21 = 0, mulherxp = 0, menoridade = 0;
        char sexo, xp;


        while (idade != 0)
        {
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade == 0)
            {
                break;
            }
            Console.WriteLine("Digite seu sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());
            if (sexo == 'M' || sexo == 'm')
            {
                sexomasc++;
            }
            if (sexo == 'F' || sexo == 'f')
            {
                sexofem++;
            }
            Console.WriteLine("Você possui experiência no serviço (S/N)?");
            xp = char.Parse(Console.ReadLine());
            if (xp == 'S' || xp == 's')
            {
                xpsim++;
                if (idade < menoridade)
                {
                    menoridade = idade;
                }
                somaIdadeHomensxp += idade;
            }
            if (xp == 'N' || xp == 'n')
            {
                xpnao++;
            }
            if (sexo == 'M' || sexo == 'm' && xp == 'S' || xp == 's')
            {
                homemxp++;
            }
            if (sexo == 'F' || sexo == 'f' && xp == 'S' || xp == 's')
            {
                mulherxp++;
            }
            if (sexo == 'M' || sexo == 'm' && idade > 45)
            {
                sexomasc = sexomasc + idade45;
                idade45++;
            }
            if (sexo == 'M' || sexo == 'm' && xp == 'S' || xp == 's' && idade < 21)
            {
                mulherxp = mulherxp + idade21;
                idade21++;
            }

        }

        Console.WriteLine("Número de candidatos do sexo feminino: " + sexofem);
        Console.WriteLine("Número de candidatos do sexo masculino: " + sexomasc);
        Console.WriteLine("Média de idade dos homens com experiência: " + ((double)somaIdadeHomensxp / homemxp).ToString("0.00"));
        Console.WriteLine("A porcentagem dos homens com mais de 45 anos entre o total dos homens é de: " + ((double)idade45 / sexomasc * 100).ToString("0.00") + "%");
        Console.WriteLine("O número de mulheres com idade inferior a 21 anos e com experiência no serviço é de: " + idade21);
        Console.WriteLine("A menor idade entre as mulheres que já têm experiência no serviço é de: " + menoridade);


    }
}