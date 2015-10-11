using System;

namespace Lista4Exercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
