using System;

namespace Batalha_Naval
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int tiro;
            int navio = r.Next(2, 10);
            int navioP1 = navio - 1;
            int navioP2 = navio;
            int navioP3 = navio + 1;

            Console.WriteLine("Posição do navio: " + (navioP1) + ", " + (navioP2) + " e " + (navioP3));

            Console.WriteLine("Digite uma posição de 1 a 10: ");
            tiro = int.Parse(Console.ReadLine());

            if (tiro >= navioP1 && tiro <= navioP3)
            {
                Console.WriteLine("Acertou! Você venceu");
            }
            else
            {
                Console.WriteLine("Água!");
                Console.WriteLine("Digite a posição do tiro: 1 à 10");
                tiro = int.Parse(Console.ReadLine());
                if (tiro >= navioP1 && tiro <= navioP3)
                {
                    Console.WriteLine("Acertou! Você venceu");
                }
                else
                {
                    Console.WriteLine("Água!");
                    Console.WriteLine("Digite a posição do tiro: 1 à 10");
                    tiro = int.Parse(Console.ReadLine());
                    if (tiro >= navioP1 && tiro <= navioP2)
                    {
                        Console.WriteLine("Acertou! Você venceu");
                    }
                    else
                    {
                        Console.WriteLine("Fim de jogo! Você perdeu!");
                        Console.WriteLine("Posicao do navio: " + (navioP1) + ", " + navioP2 + " e " + (navioP3));
                    }
                }
            }
        }
    }
}
