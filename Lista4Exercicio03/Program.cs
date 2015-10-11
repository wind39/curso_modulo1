using System;

namespace Lista4Exercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nome;
            int idade;
            char sexo;
            string sexoporextenso;
            double nota1, nota2, nota3, media;
            string situacao;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade do aluno: ");
            idade = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o sexo do aluno (M ou F): ");
                sexo = Char.Parse(Console.ReadLine());

                if (char.ToUpper(sexo) != 'M' && char.ToUpper(sexo) != 'F')
                    Console.WriteLine("ERRO! Sexo {0} inválido.", sexo);
            }
            while (char.ToUpper(sexo) != 'M' && char.ToUpper(sexo) != 'F');

            do
            {
                Console.Write("Digite a nota da prova 1: ");
                nota1 = double.Parse(Console.ReadLine());

                if (nota1 < 0 || nota1 > 10)
                    Console.WriteLine("ERRO! Nota {0} inválida.", nota1);
            }
            while (nota1 < 0 || nota1 > 10);

            do
            {
                Console.Write("Digite a nota da prova 2: ");
                nota2 = double.Parse(Console.ReadLine());

                if (nota2 < 0 || nota2 > 10)
                    Console.WriteLine("ERRO! Nota {0} inválida.", nota2);
            }
            while (nota2 < 0 || nota2 > 10);

            do
            {
                Console.Write("Digite a nota da prova 3: ");
                nota3 = double.Parse(Console.ReadLine());

                if (nota3 < 0 || nota3 > 10)
                    Console.WriteLine("ERRO! Nota {0} inválida.", nota3);
            }
            while (nota3 < 0 || nota3 > 10);

            media = ((1 * nota1) + (2 * nota2) + (3 * nota3)) / 6.0;

            if (char.ToUpper(sexo) == 'M')
                sexoporextenso = "masculino";
            else
                sexoporextenso = "feminino";

            if (media >= 7)
                situacao = "aprovado";
            else
                situacao = "reprovado";

            Console.WriteLine("O aluno {0} tem {1} anos, é do sexo {2} e obteve a nota final = {3}, situação {4}.", nome, idade, sexoporextenso, media, situacao);

            Console.ReadKey();
        }
    }
}
