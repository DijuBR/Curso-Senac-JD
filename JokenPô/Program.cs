using System;

namespace JokenPô
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int jogada, jogadapc, resp, jogadaf;



            Console.WriteLine("JokenPo \n" +
                "\nPlayer vs Computador\n");


            Console.WriteLine("1 - Pedra\n" +
                "2 - Papel\n" +
                "3 - Tesoura\n" +
                "Jogada: ");
            jogada = int.Parse(Console.ReadLine());
            jogadapc = r.Next(1, 4);
            resp = jogada - jogadapc;


            if (jogada < 1 || jogada > 3)
            {
                Console.Write("ERRO, jogue um número de 1 a 3!!!");
            }
            else
            {
                if (jogada == 1)
                {

                }





            }
        }
    }
}
