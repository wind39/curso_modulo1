using System;

namespace Lista2Exercicio06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o valor da variavel A: ");
            a = int.Parse(Console.ReadLine());

            b = a * a;

            Console.WriteLine("O quadrado de A = {0}", b);

            Console.ReadKey();
        }
    }
}
