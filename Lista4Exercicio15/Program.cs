using System;

namespace Lista4Exercicio15
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
            i = 2;
            while (i < n && !achou)
            {
                if (n % i == 0)
                    achou = true;
                else
                    i++;
            }

            if (achou)
                Console.WriteLine("{0} não é primo, pois {1}, por exemplo, é um múltiplo de {0}.", n, i);
            else
                Console.WriteLine("{0} é primo.", n);

            Console.ReadKey();
        }
    }
}
