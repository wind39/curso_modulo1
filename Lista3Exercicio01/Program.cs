using System;

namespace Lista3Exercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
                Console.WriteLine("{0} é par.", x);
            else
                Console.WriteLine("{0} é ímpar.", x);

            Console.ReadKey();
        }
    }
}
