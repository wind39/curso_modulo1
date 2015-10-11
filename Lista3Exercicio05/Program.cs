using System;

namespace Lista3Exercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nome;
            int idade;
            string genero;
            double nota;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o gênero: ");
            genero = Console.ReadLine();

            if (genero.ToLower() != "m" && genero.ToLower() != "f" && genero.ToLower() != "masculino" && genero.ToLower() != "feminino")
            {
                Console.WriteLine("ERRO: Gênero incorreto, pode ser apenas M/m ou F/f, ou por extenso, masculino ou feminino.");
                Console.WriteLine("O programa será encerrado.");
            }
            else
            {
                Console.Write("Digite a nota: ");
                nota = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Nome = {0}", nome);
                Console.WriteLine("Idade = {0}", idade);
                if (genero.ToLower() == "m" || genero.ToLower() == "masculino")
                    Console.WriteLine("Gênero = Masculino");
                else
                    Console.WriteLine("Gênero = Feminino");
                Console.WriteLine("Nota = {0}", nota);
            }

            Console.ReadKey();
        }
    }
}
