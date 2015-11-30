using System;

namespace Lista6Exercicio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // matriz real A
            double[,] a;
            // matriz real B
            double[,] b;
            // m: número de linhas de A
            // n: número de colunas de A, e número de linhas de B
            // p: número de colunas de B
            int m, n, p;
            // matriz real C, que é o produto de A por B
            double[,] c;

            // dimensões
            Console.Write("Digite o valor de M, que será o número de linhas de A: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de N, que será o número de colunas de A e número de linhas de B: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de P, que será o número de colunas de B: ");
            p = int.Parse(Console.ReadLine());

            // alocando as matrizes
            a = new double[m,n];
            b = new double[n,p];

            // definicao do tamanho de C
            // Cmxp = Amxn . Bnxp

            // alocando a matriz resultante C
            c = new double[m,p];

            // solicitando ao usuário para digitar os elementos da matriz A
            Console.WriteLine();
            Console.WriteLine("Digite os elementos de A:");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Digite o elemento [{0},{1}]: ", i, j);
                    a[i, j] = double.Parse(Console.ReadLine());
                }

            // solicitando ao usuário para digitar os elementos da matriz B
            Console.WriteLine();
            Console.WriteLine("Digite os elementos de B:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < p; j++)
                {
                    Console.Write("Digite o elemento [{0},{1}]: ", i, j);
                    b[i, j] = double.Parse(Console.ReadLine());
                }

            // multiplicacao
            /* Código do Felipe
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < p; j++) {
                for (int k = 0; k < n; k++) {
                matrizP [i, j] += matrizA [i, k] * matrizB [k, j];
                }
                Console.WriteLine ("P[{0},{1}]: {2}",i, j, matrizP [i,j]);
                }
                }
            */

            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                {
                    c[i,j] = 0;
                    for (int k = 0; k < n; k++)
                        c[i,j] += a[i,k] * b[k,j];
                }       

            // impressão da matriz resultante
            Console.WriteLine();
            Console.WriteLine("A matriz resultante C da multiplicação entre A e B ficou:");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    Console.WriteLine("C[{0},{1}] = {2}", i, j, c[i,j]);

            Console.ReadKey();
        }
    }
}
