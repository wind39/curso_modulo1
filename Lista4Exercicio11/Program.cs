using System;

namespace Lista4Exercicio11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, soma, x;

            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} - Digite um número inteiro: ", i);
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                    soma += x;
            }

            Console.WriteLine("A soma dos números pares da sequência é igual a {0}.", soma);

            Console.ReadKey();
        }
    }
}
