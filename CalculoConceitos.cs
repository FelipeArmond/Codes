using System;

namespace listassequenciais {
    class program {
        static void Main(string[] args) 
        {
            int trabalholab;
            int avalsemestral;
            int examefinal;
            int notatrab;
            int notaaval;
            int notaexame;
            float mediaponderada;

            Console.WriteLine("Qual a nota obtida no trabalho de laboratório?");
            trabalholab = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota obtida na avaliação semestral?");
            avalsemestral = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota obtida no exame final?");
            examefinal = int.Parse(Console.ReadLine());

            notatrab = trabalholab * 2;
            notaaval = avalsemestral * 3;
            notaexame = examefinal * 5;
            mediaponderada = (notatrab + notaaval + notaexame )/ (2 + 3 + 5);

            if (mediaponderada >= 8 && mediaponderada <= 10) 
            {
                Console.WriteLine("Conceito A");
            }
            else if (mediaponderada >= 7 && mediaponderada <8) 
            {
                Console.WriteLine("Conceito B");
            }
            if (mediaponderada >= 6 && mediaponderada <= 7) 
            {
                Console.WriteLine("Conceito C");
            }
            else if (mediaponderada >= 5 && mediaponderada < 6) 
            {
                Console.WriteLine("Conceito D");
            }
            if (mediaponderada >= 0 && mediaponderada < 5) 
            {
                Console.WriteLine("Conceito E");
            }
        }
    }
}