using System;

namespace Aula6_Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada\n" +
                                    " de pontos no sistema cartesiano.Para cada ponto escrever o quadrante a que ele\n" +
                                     "pertence.O algoritmo será encerrado quando pelo menos uma de duas coordenadas\n" +
                                    " for NULA(nesta situação sem escrever mensagem alguma).");

            int x, y;
            do
            {


                Console.WriteLine("Insira dois valores interios. ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");
                }

            } while (x != 0 && y != 0);

        }
    }
}
