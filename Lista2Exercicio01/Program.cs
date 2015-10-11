using System;

namespace Lista2Exercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // declarar 3 variaveis, a, b, e c
            int a, b, c;

            // pedir para o usuario digitar o valor da variavel A
            Console.Write("Digite o valor da variavel A: ");
            a = int.Parse(Console.ReadLine());

            // pedir para o usuario digitar o valor da variavel B
            Console.Write("Digite o valor da variavel B: ");
            b = int.Parse(Console.ReadLine());

            // calcular a operação e jogar o resultado em C
            c = a + b;

            // mostrar o valor de C para o usuario
            Console.WriteLine("A soma de A e B = {0}", c);
            Console.ReadKey();
        }
    }
}
