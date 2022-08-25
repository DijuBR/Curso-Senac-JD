using System;

namespace Tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####Tabuleiro com Dados#####");
            int his, player = 1, tabuleiro, posicao, somaD, dados, novaPos;
            Random r = new Random();


            while (player != 20)
            {
               
                dados = r.Next(1, 7);
                somaD = dados + player;
                player = somaD;
                Console.WriteLine("Sua Posição: " + player);
                Console.WriteLine("Seu Dado: " + dados);
                Console.ReadLine();
                Console.Clear();

                if (player == 17)
                {
                    Console.WriteLine(@"
██████   ██████  ██      ███████  ██████  ███    ██  █████  ██████   ██████       ██ ███████ 
██   ██ ██    ██ ██      ██      ██    ██ ████   ██ ██   ██ ██   ██ ██    ██     ███      ██ 
██████  ██    ██ ██      ███████ ██    ██ ██ ██  ██ ███████ ██████  ██    ██      ██     ██  
██   ██ ██    ██ ██           ██ ██    ██ ██  ██ ██ ██   ██ ██   ██ ██    ██      ██    ██   
██████   ██████  ███████ ███████  ██████  ██   ████ ██   ██ ██   ██  ██████       ██    ██   
                                                                                             
                                                                                             ");
                    Console.WriteLine("Deu ruim, volte para 64... 6ª casa");
                    player = 6;
                }
                if(player == 13)
                {
                    Console.WriteLine(@"
██      ██    ██ ██       █████       ██ ██████  
██      ██    ██ ██      ██   ██     ███      ██ 
██      ██    ██ ██      ███████      ██  █████  
██      ██    ██ ██      ██   ██      ██      ██ 
███████  ██████  ███████ ██   ██      ██ ██████  
                                                 
                                                 
");
                    Console.WriteLine("Você saudou a mandioca, avançe duas casas");
                    player = 15;
                }

                if (player > 20)
                {
                    player = 1;
                    Console.WriteLine("Você voltou para a : " + player);
                }




            }
        }
    }
}

