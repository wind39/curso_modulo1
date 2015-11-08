using System;

namespace Lista5Exercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            int face;
            int[] vetor;

            vetor = new int[7];

            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = 0;

            Console.Write("Quantos lançamentos serão feitos? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite o lançamento {0}: ", i);
                face = int.Parse(Console.ReadLine());

                if (face < 1 || face > 6)
                    vetor[0]++;
                else
                    vetor[face]++;
            }

            Console.WriteLine();
            Console.WriteLine("Número de ocorrências de cada face:");

            for (int i = 1; i < vetor.Length; i++)
                Console.WriteLine("Face {0} = {1}", i, vetor[i]);

            Console.WriteLine("Você digitou faces inválidas {0} vezes.", vetor[0]);

            Console.ReadKey();
        }
    }
}
