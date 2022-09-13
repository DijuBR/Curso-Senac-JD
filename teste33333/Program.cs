using System;
using System.Threading;

namespace teste33333
{
    class Snake
    {
        //TAMANHO DA TELA
        int altura = 21; //Altura da tela
        int largura = 51; //Largura da tela


        int[] x = new int[50];
        int[] y = new int[50];

        bool derrota;

        int frutaX;
        int frutaY;

        int cobra = 3;
        int pontos = 0;
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 's';

        Random rnd = new Random();

        Snake()
        {
            x[0] = 26;
            y[0] = 11;
            Console.CursorVisible = false;
            frutaX = rnd.Next(2, (largura - 2));
            frutaY = rnd.Next(2, (altura - 2));
        }

        public void WriteBoard()
        //PRINTAR A TELA (Você pode alterar o tamanho se quiser em: Line 9,10)
        {
            Console.Clear();
            for (int i = 1; i <= (largura + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine("_");
            }
            for (int i = 1; i <= (largura + 2); i++)
            {
                Console.SetCursorPosition(i, (altura + 2));
                Console.WriteLine("-");
            }
            for (int i = 1; i <= (altura + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");
            }
            for (int i = 1; i <= (altura + 1); i++)
            {
                Console.SetCursorPosition((largura + 2), i);
                Console.WriteLine("|");
            }
            Console.WriteLine("\nPontuação: " + pontos);
        }
        public void Input()
        //Teclado
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }
        public void Logic()
        {

            if (x[0] <= 1 || x[0] > 52 || y[0] < 2 || y[0] > 22)
            {
                Console.WriteLine("Perdeu!!!!!!!!!");
                derrota = true;
            }

            for (int i = 1; i < cobra; i++)
            {
                if (x[0] == x[i] && y[0] == y[i])
                {
                    Console.WriteLine("Perdeu 222222!!!!!!!!!");
                    derrota = true;
                }
            }

            if (x[0] == frutaX)
            {
                if (y[0] == frutaY)
                {
                    cobra++;
                    pontos += 100;
                    frutaX = rnd.Next(2, (largura - 2));
                    frutaY = rnd.Next(2, (altura - 2));
                }
            }
            for (int i = cobra; i > 1; i--)
            {
                x[i - 1] = x[i - 2];
                y[i - 1] = y[i - 2];
            }
            switch (key)
            {
                case 'w':
                    y[0]--;
                    break;
                case 's':
                    y[0]++;
                    break;
                case 'd':
                    x[0]++;
                    break;
                case 'a':
                    x[0]--;
                    break;
            }
            for (int i = 0; i <= (cobra - 1); i++)
            {
                WritePoint(x[i], y[i]);
                WritePoint(frutaX, frutaY);
            }
            Thread.Sleep(200 - (3 * cobra));
        }

        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("█");
        }
        static void Main(string[] args)
        {
            Snake.start();
            Snake snake = new Snake();
            while (!snake.derrota)
            {
                snake.WriteBoard();
                snake.Input();
                snake.Logic();
            }
            Console.ReadLine();
        }
        static void start()
        {
            Console.WriteLine(@"
 _________  ___  ___  ________  ________  ________          ________  ________   ________  ___  __    _______      
|\___   ___\\  \|\  \|\   __  \|\   __  \|\   __  \        |\   ____\|\   ___  \|\   __  \|\  \|\  \ |\  ___ \     
\|___ \  \_\ \  \\\  \ \  \|\  \ \  \|\ /\ \  \|\  \       \ \  \___|\ \  \\ \  \ \  \|\  \ \  \/  /|\ \   __/|    
     \ \  \ \ \  \\\  \ \   _  _\ \   __  \ \  \\\  \       \ \_____  \ \  \\ \  \ \   __  \ \   ___  \ \  \_|/__  
      \ \  \ \ \  \\\  \ \  \\  \\ \  \|\  \ \  \\\  \       \|____|\  \ \  \\ \  \ \  \ \  \ \  \\ \  \ \  \_|\ \ 
       \ \__\ \ \_______\ \__\\ _\\ \_______\ \_______\        ____\_\  \ \__\\ \__\ \__\ \__\ \__\\ \__\ \_______\
        \|__|  \|_______|\|__|\|__|\|_______|\|_______|       |\_________\|__| \|__|\|__|\|__|\|__| \|__|\|_______|
                                                              \|_________|                                         
                                                                                                                   
                                                                                                                   
");
            Console.WriteLine("                                               PRESSIONE ENTER PARA JOGAR                                           ");
            Console.WriteLine("W - Cima\n" + "A - Esquerda\n" + "S - Baixo\n" + "D - Direita\n");
            Console.WriteLine("AVISO: NÃO JOGUE SE TIVER PROBLEMAS COM ATAQUE EPILÉTICO, EPILEPSIA E ESSAS COISAS");
            Console.WriteLine("A EQUIPE NÃO SE RESPONSABILIZA POR DAUNOS CAUSADOS A QUEM FOR TESTAR O NOSSO JOGO!");
            Console.ReadLine();
            
        }
    }
}

