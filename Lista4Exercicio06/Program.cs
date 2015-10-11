using System;

namespace Lista4Exercicio06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, j;

            do
            {
                Console.Write("Digite N maior ou igual a zero: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                    Console.WriteLine("Erro! N precisa ser maior ou igual a zero.");
            }
            while (n < 0);

            Console.Write("{0}", 1);
            j = 3;
            for (int i = 1; i < n; i++)
            {
                Console.Write(",{0}", j);
                j += 2;
            }

            Console.ReadKey();
        }
    }
}
