using System;

namespace Lista3Exercicio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double x;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine());

            if (x >= 0)
                Console.WriteLine("A raiz quadrada de {0} é {1}.", x, Math.Sqrt(x));
            else
                Console.WriteLine("Não existe raiz quadrada de números negativos entre os números reais.");

            Console.ReadKey();
        }
    }
}
