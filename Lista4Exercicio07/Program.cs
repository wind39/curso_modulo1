using System;

namespace Lista4Exercicio07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double t;
            int dias;

            dias = 0;
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Digite a temperatura média no dia {0}: ", i);
                t = double.Parse(Console.ReadLine());

                if (t < 0)
                    dias++;
            }

            Console.WriteLine("O número de dias com temperatura abaixo de zero foi {0}.", dias);

            Console.ReadKey();
        }
    }
}
