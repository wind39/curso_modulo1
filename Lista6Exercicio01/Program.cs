using System;

namespace Lista6Exercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // matriz real A
            double[,] a;
            // vetor real V
            double[] v;
            // m: número de linhas de A
            // n: número de colunas de A, e número de elementos de V
            int m, n;
            // vetor real P, que é o produto de A por V
            double[] p;

            // dimensões
            Console.Write("Digite o valor de M, que será o número de linhas de A: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de N, que será o número de colunas de A e número de elementos de V: ");
            n = int.Parse(Console.ReadLine());

            // alocando as matrizes e o vetor
            a = new double[m,n];
            v = new double[n];

            // definicao do tamanho de P
            // regra geral: Amxp . Bpxn = Cmxn
            // Amxn . Vnx1 = Pmx1

            // alocando o vetor resultante p
            p = new double[m];

            // solicitando ao usuário para digitar os elementos da matriz A
            Console.WriteLine();
            Console.WriteLine("Digite os elementos de A:");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Digite o elemento [{0},{1}]: ", i, j);
                    a[i, j] = double.Parse(Console.ReadLine());
                }

            // solicitando ao usuário para digitar os elementos do vetor V
            Console.WriteLine();
            Console.WriteLine("Digite os elementos de V:");
            for (int j = 0; j < n; j++)
            {
                Console.Write("Digite o elemento [{0}]: ", j);
                v[j] = double.Parse(Console.ReadLine());
            }

            // multiplicacao
            for (int i = 0; i < m; i++)
            {
                p[i] = 0;
                for (int j = 0; j < n; j++)
                    p[i] += a[i,j] * v[j];
            }

            // impressão do vetor resultante
            Console.WriteLine();
            Console.WriteLine("O vetor resultante P da multiplicação entre A e V ficou:");
            for (int i = 0; i < m; i++)
                Console.WriteLine("P[{0}] = {1}", i, p[i]);

            Console.ReadKey();
        }
    }
}
