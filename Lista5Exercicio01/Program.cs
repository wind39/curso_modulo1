using System;
using System.Collections.Generic;

namespace Lista5Exercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> vetor;
            int n;

            vetor = new List<int>();

            Console.Write("Quantos números? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite o número {0}: ", i);
                vetor.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Os números que você digitou, na ordem inversa, são: ");

            for (int i = vetor.Count-1; i >= 0; i--)
                Console.WriteLine(vetor[i]);

            Console.ReadKey();
        }
    }
}
