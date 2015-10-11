using System;

namespace Lista3Exercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            if (x <= 0 || x > 100)
                Console.WriteLine("{0} não está no intervalo entre 1 e 100.", x);
            else
            {
                if (x >= 1 && x <= 10)
                    Console.WriteLine("{0} está entre 1 e 10.", x);

                if (x >= 11 && x <= 20)
                    Console.WriteLine("{0} está entre 11 e 20.", x);

                if (x >= 21 && x <= 30)
                    Console.WriteLine("{0} está entre 21 e 30.", x);

                if (x >= 31 && x <= 40)
                    Console.WriteLine("{0} está entre 31 e 40.", x);

                if (x >= 41 && x <= 50)
                    Console.WriteLine("{0} está entre 41 e 50.", x);

                if (x >= 51 && x <= 60)
                    Console.WriteLine("{0} está entre 51 e 60.", x);

                if (x >= 61 && x <= 70)
                    Console.WriteLine("{0} está entre 61 e 70.", x);

                if (x >= 71 && x <= 80)
                    Console.WriteLine("{0} está entre 71 e 80.", x);

                if (x >= 81 && x <= 90)
                    Console.WriteLine("{0} está entre 81 e 90.", x);

                if (x >= 91 && x <= 100)
                    Console.WriteLine("{0} está entre 91 e 100.", x);
            }

            Console.ReadKey();
        }
    }
}
