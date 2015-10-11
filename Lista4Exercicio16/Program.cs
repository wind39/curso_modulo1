using System;

namespace Lista4Exercicio16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n1i, n2i, n1, n2;
            int resto;

            do
            {
                Console.Write("Digite o primeiro número inteiro maior que zero: ");
                n1i = int.Parse(Console.ReadLine());

                if (n1i <= 0)
                    Console.WriteLine("Erro! Número deve ser maior que zero.");
            }
            while (n1i <= 0);

            do
            {
                Console.Write("Digite o primeiro número inteiro maior que zero: ");
                n2i = int.Parse(Console.ReadLine());

                if (n2i <= 0)
                    Console.WriteLine("Erro! Número deve ser maior que zero.");
            }
            while (n2i <= 0);

            if (n2i > n1i)
            {
                n1 = n2i;
                n2 = n1i;
            }
            else
            {
                n1 = n1i;
                n2 = n2i;
            }

            resto = n1 % n2;
            while (resto > 0)
            {
                n1 = n2;
                n2 = resto;
                resto = n1 % n2;
            }

            Console.WriteLine("O MDC entre {0} e {1} é {2}", n1i, n2i, n2);

            Console.ReadKey();
        }
    }
}
