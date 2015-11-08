using System;
using System.Collections.Generic;

namespace Lista5Exercicio04
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

            for (int k = 1; k <= 1000; k++)
            {
                n = k.ToString();

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
                    Console.WriteLine(n);

                vetor1.Clear();
                vetor2.Clear();
            }

            Console.ReadKey();
        }
    }
}
