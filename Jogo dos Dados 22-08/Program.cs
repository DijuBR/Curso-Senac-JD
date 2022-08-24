using System;

namespace Jogo_dos_Dados_22_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#######Jogo dos Dados#######");
            int jogadas, d1p, d2p, d1c, d2c, winP, winC, emp;
            Random r = new Random();
            jogadas = 0;
            winC = 0;
            winP = 0;
            emp = 0;
            while(jogadas < 10)
            {
                Console.WriteLine("Jogada: "+ jogadas +"\nDados Player: " + (d1p = r.Next(1, 7)) + " E " + (d2p = r.Next(1,7)));
                Console.WriteLine("Dados     PC: " + (d1c = r.Next(1, 7)) + " E " + (d2c = r.Next(1, 7)));
                jogadas++;
                if((d1p + d2p) == (d1c + d2c))
                {
                    Console.WriteLine("####!!!EMPATE!!!####");
                    emp++;
                }
                else
                {
                    if((d1p + d2p) > (d1c + d2c))
                    {
                        Console.WriteLine("####!!!PLAYER VENCEU!!!####");
                        winP++;
                    }
                    else
                    {
                        Console.WriteLine("####!!!PC VENCEU!!!####");
                        winC++;
                    }
                }
            }
            Console.WriteLine("Vitóras Player: " + winP);
            Console.WriteLine("Vitóras PC    : " + winC);
            Console.WriteLine("Empates       : " + emp);

            if(winP > winC)
            {
                Console.WriteLine("!!!!!!!!!!PLAYER VENCEU!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("!!!!!!!!!!!PC VENCEU!!!!!!!!!!");
            }

        }
    }
}