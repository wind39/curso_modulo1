using System;

namespace Lista4Exercicio14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, i;
            bool achou;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            achou = false;
            i = 1;
            while (i < n && ! achou)
            {
                if ((i * (i + 1) * (i + 2)) == n)
                    achou = true;
                else
                    i++;
            }

            if (achou)
                Console.WriteLine("O número {0} é triangular, pois {1}.{2}.{3} = {0}.", n, i, i+1, i+2);
            else
                Console.WriteLine("O número {0} não é triangular.", n);

            Console.ReadKey();
        }
    }
}
