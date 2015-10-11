using System;

namespace Lista3Exercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            if (x == 0)
                Console.WriteLine("{0} é igual a zero.", x);
            
            if (x != 0)
                Console.WriteLine("{0} é diferente de zero.", x);

            if (x > 0)
                Console.WriteLine("{0} é maior que zero.", x);

            if (x <= 0)
                Console.WriteLine("{0} é menor ou igual a zero.", x);

            if (x < 0)
                Console.WriteLine("{0} é menor que zero.", x);

            if (x >= 0)
                Console.WriteLine("{0} é maior ou igual a zero.", x);

            Console.ReadKey();
        }
    }
}
