using System;

namespace Modulo1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] vetor;
            int aux;
			
            vetor = new int[5];

			/*vetor[0] = 4;
			vetor[1] = 7;
			vetor[2] = 10;
			vetor[3] = 1;
			vetor[4] = 5;*/

            vetor[0] = 9000;
            vetor[1] = 1800;
            vetor[2] = 250;
            vetor[3] = 0;
            vetor[4] = -35;

			// Início algoritmo Bubble Sort

            for (int a = 0; a < vetor.Length - 1; a++)
            {
                for (int x = a + 1; x < vetor.Length; x++)
                {
                    if (vetor[a] > vetor[x])
                    {
                        aux = vetor[x];
                        vetor[x] = vetor[a];
                        vetor[a] = aux;
                    }
                }
            }

            // Fim algoritmo Bubble Sort

			for (int i = 0; i < vetor.Length; i++)
				Console.WriteLine (vetor[i]);

            Console.ReadKey();
        }
    }
}
