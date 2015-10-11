using System;

namespace Lista4Exercicio13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, i, j, k, cont;

            do
            {
                Console.Write("Digite o valor de N: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                    Console.WriteLine("Erro! N precisa ser maior que zero.");
            }
            while (n <= 0);

            do
            {
                Console.Write("Digite o valor de I: ");
                i = int.Parse(Console.ReadLine());

                if (i <= 0)
                    Console.WriteLine("Erro! I precisa ser maior que zero.");
            }
            while (i <= 0);

            do
            {
                Console.Write("Digite o valor de J: ");
                j = int.Parse(Console.ReadLine());

                if (j <= 0)
                    Console.WriteLine("Erro! J precisa ser maior que zero.");
            }
            while (j <= 0);

            Console.Write("0");
            cont = 1;
            k = 1;
            while (cont < n)
            {
                if (k % i == 0 || k % j == 0)
                {
                    Console.Write(", {0}", k);
                    cont++;
                }

                k++;
            }

            Console.ReadKey();
        }
    }
}
