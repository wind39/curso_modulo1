using System;

namespace Lista2Exercicio11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            double x1, x2;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            x1 = ((-1 * b) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            x2 = ((-1 * b) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            Console.WriteLine("X1 = {0}", x1);
            Console.WriteLine("X2 = {0}", x2);

            Console.ReadKey();
        }
    }
}
