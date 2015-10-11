using System;

namespace Lista4Exercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int tabuada, n;

            Console.Write("Digite a tabuada desejada: ");
            tabuada = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de vezes: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                Console.WriteLine("{0} x {1} = {2}", tabuada, i, (tabuada * i));

            Console.ReadKey();
        }
    }
}
