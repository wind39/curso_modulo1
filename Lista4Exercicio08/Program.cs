using System;

namespace Lista4Exercicio08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x, n;
            int potencia;

            Console.Write("Digite um inteiro X: ");
            x = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite N maior ou igual a zero: ");
                n = int.Parse(Console.ReadLine());

                if (n < 0)
                    Console.WriteLine("Erro! N precisa ser maior ou igual a zero.");
            }
            while (n < 0);

            potencia = 1;
            for (int i = 0; i < n; i++)
                potencia *= x;

            Console.WriteLine("{0} elevado a {1} é igual a {2}", x, n, potencia);

            Console.ReadKey();
        }
    }
}
