using System;

namespace Lista4Exercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            int maiornota, menornota, nota;
            int maioraluno, menoraluno;

            Console.Write("Quantos alunos estão estudando no curso atualmente: ");
            n = int.Parse(Console.ReadLine());

            maiornota = -1;
            menornota = 101;
            maioraluno = 0;
            menoraluno = 0;
            for (int i = 1; i <= n; i++)
            {
                do
                {
                    Console.Write("Qual é a nota do aluno {0}? ", i);
                    nota = int.Parse(Console.ReadLine());

                    if (nota < 0 || nota > 100)
                        Console.WriteLine("Erro! Nota deve estar entre 0 e 100.");
                }
                while (nota < 0 || nota > 100);

                if (nota > maiornota)
                {
                    maiornota = nota;
                    maioraluno = i;
                }

                if (nota < menornota)
                {
                    menornota = nota;
                    menoraluno = i;
                }
            }

            Console.WriteLine("O aluno {0} obteve a maior nota, que foi {1}.", maioraluno, maiornota);
            Console.WriteLine("O aluno {0} obteve a menor nota, que foi {1}.", menoraluno, menornota);

            Console.ReadKey();
        }
    }
}
