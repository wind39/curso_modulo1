using System;

namespace Lista4Exercicio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite números para obter seus quadrados.");
            Console.WriteLine("Quando quiser parar, digite 0.");

            do
            {
                n = int.Parse(Console.ReadLine());

                if (n != 0)
                    Console.WriteLine("O quadrado de {0} é {1}.", n, (n * n));
            }
            while (n != 0);

            Console.ReadKey();
        }
    }
}
