using System;

namespace Lista2Exercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o valor da variavel A: ");
            a = int.Parse(Console.ReadLine());

            b = a * 2;

            Console.WriteLine("O dobro de A = {0}", b);

            Console.ReadKey();
        }
    }
}
