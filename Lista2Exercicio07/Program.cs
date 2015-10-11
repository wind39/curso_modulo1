using System;

namespace Lista2Exercicio07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nome;
            int idade;
            char genero;
            double nota;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o gênero: ");
            genero = char.Parse(Console.ReadLine());

            Console.Write("Digite a nota: ");
            nota = double.Parse(Console.ReadLine());

            Console.WriteLine("Nome = {0}", nome);
            Console.WriteLine("Idade = {0}", idade);
            Console.WriteLine("Gênero = {0}", genero);
            Console.WriteLine("Nota = {0}", nota);

            Console.ReadKey();
        }
    }
}
