using System;

namespace Lista4Exercicio09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int q, maior, dia;

            maior = 0;
            dia = 0;
            for (int i = 1; i <= 31; i++)
            {
                Console.Write("Quantos discos foram vendidos no dia {0}? ", i);
                q = int.Parse(Console.ReadLine());

                if (q > maior)
                {
                    maior = q;
                    dia = i;
                }
            }

            Console.WriteLine("O recorde de vendas foi no dia {0}, com {1} discos vendidos.", dia, maior);

            Console.ReadKey();
        }
    }
}
