using System;

namespace Lista2Exercicio08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int totalsegundos;
            int segundos;
            int minutos;
            int horas;

            Console.Write("Digite o total em segundos: ");
            totalsegundos = int.Parse(Console.ReadLine());

            segundos = totalsegundos;

            horas = segundos / 3600;
            segundos = segundos - (3600 * horas);

            minutos = segundos / 60;
            segundos = segundos - (60 * minutos);

            Console.WriteLine("{0} segundos é equivalente a {1} horas, {2} minutos e {3} segundos", totalsegundos, horas, minutos, segundos);
            Console.ReadKey();
        }
    }
}
