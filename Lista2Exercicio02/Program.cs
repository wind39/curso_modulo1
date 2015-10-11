using System;

namespace Lista2Exercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o valor da variavel A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da variavel B: ");
            b = int.Parse(Console.ReadLine());

            c = a - b;

            Console.WriteLine("A subtração de A e B = {0}", c);
            Console.ReadKey();
        }
    }
}
