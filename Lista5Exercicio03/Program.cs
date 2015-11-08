using System;
using System.Collections.Generic;

namespace Lista5Exercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<char> vetor1, vetor2;
            string n;
            bool palindromo;
            int i;

            vetor1 = new List<char>();
            vetor2 = new List<char>();

            Console.Write("Digite um número natural: ");
            n = uint.Parse(Console.ReadLine()).ToString();

            foreach (char c in n.ToCharArray())
            {
                vetor1.Add(c);
                vetor2.Add(c);
            }
            vetor2.Reverse();

            palindromo = true;
            i = 0;
            while (i < vetor1.Count && palindromo)
            {
                palindromo = vetor1[i] == vetor2[i];
                i++;
            }

            if (palindromo)
                Console.WriteLine("O número {0} é palíndromo.", n);
            else
                Console.WriteLine("O número {0} não é palíndromo.", n);

            Console.ReadKey();
        }
    }
}
