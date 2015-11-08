using System;
using System.Collections.Generic;

namespace Lista5Exercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> vetor;
            string n;
            bool negativo;

            vetor = new List<int>();

            Console.Write("Digite um número inteiro: ");
            n = Console.ReadLine();

            negativo = false;
            foreach (char c in n.ToCharArray())
            {
                if (c == '-')
                    negativo = true;
                else
                    vetor.Add(int.Parse(c.ToString()));
            }
            vetor.Reverse();

            if (negativo)
                Console.Write("{0} = -{1} - ", n, (vetor[vetor.Count-1] * Math.Pow(10, vetor.Count-1)));
            else
                Console.Write("{0} = {1} + ", n, (vetor[vetor.Count-1] * Math.Pow(10, vetor.Count-1)));
            for (int i = vetor.Count - 2; i > 0; i--)
            {
                if (negativo)
                    Console.Write("{0} - ", (vetor[i] * Math.Pow(10, i)));
                else
                    Console.Write("{0} + ", (vetor[i] * Math.Pow(10, i)));
            }
            Console.WriteLine("{0}", vetor[0]);

            Console.ReadKey();
        }
    }
}
