using System;

namespace Lista4Exercicio12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, fatorial;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("{0}! = {0} ", n);

            fatorial = n;
            for (int i = n - 1; i > 1; i--)
            {
                Console.Write("* {0} ", i);
                fatorial *= i;
            }

            Console.WriteLine("* 1 = {0}", fatorial);

            Console.ReadKey();
        }
    }
}
