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

        int frutaX;
        int frutaY;

        int cobra = 3;
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
        //PRINTAR A TELA (Você pode alterar o tamanho se quiser)
        {
            Console.Clear();
            for(int i = 1; i <= (largura + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine("_");
            }
            for (int i = 1; i <= (largura+2); i++)
            {
                Console.SetCursorPosition(i,(altura+2));
                Console.WriteLine("-");
            }
            for (int i = 1; i <= (altura + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");
            }
            for (int i = 1; i <= (altura + 1); i++)
            {
                Console.SetCursorPosition((largura+2), i);
                Console.WriteLine("|");
            }
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

            if(x[0] <= 1 || x[0] > 52 || y[0] < 2 || y[0] > 22)
            {
                Console.WriteLine("Perdeu!!!!!!!!!");
            }

            for(int i=1; i < cobra; i++)
            {
                if(x[0] == x[i] && y[0]==y[i])
                {
                    Console.WriteLine("Perdeu 222222!!!!!!!!!");
                }
            }

            if (x[0] == frutaX)
            {
                if (y[0] == frutaY)
                {
                    cobra++;
                    frutaX = rnd.Next(2, (largura - 2));
                    frutaY = rnd.Next(2, (altura - 2));
                }
            }
            for(int i = cobra;i>1;i--)
            {
                x[i-1] = x[i - 2];
                y[i-1] = y[i - 2];
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
            for(int i=0;i<=(cobra-1); i++)
            {
                WritePoint(x[i], y[i]);
                WritePoint(frutaX, frutaY);
            }
            Thread.Sleep(200 - (5 * cobra));
        }

        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("█");
        }
        static void Main(string[] args)
        {
        Snake snake = new Snake();
            while (true)
                
            {
                snake.WriteBoard();
                snake.Input();
                snake.Logic();
            }
            Console.ReadLine();
        }

    }
}

