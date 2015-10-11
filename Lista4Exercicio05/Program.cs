using System;

namespace Lista4Exercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, soma;

            do
            {
                Console.Write("Digite N maior ou igual a zero: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                    Console.WriteLine("Erro! N precisa ser maior ou igual a zero.");
            }
            while (n < 0);

            soma = 0;
            for (int i = 0; i < n; i++)
                soma += i;

            Console.WriteLine("A soma dos {0} primeiros números naturais é igual a {1}.", n, soma);

            Console.ReadKey();
        }
    }
}
