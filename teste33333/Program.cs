using System;

namespace teste33333
{
    class Snake
    {
        //TAMANHO DA TELA
        int altura = 20;
        int largura = 50;

        int[] x = new int[50];
        int[] y = new int[50];

        int frutaX;
        int frutaY;

        int cobra = 3;
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';

        Random rnd = new Random();

        Snake()
        {
            x[0] = 5;
            y[0] = 5;
            Console.CursorVisible = false;
            frutaX = rnd.Next(2, (altura - 2));
            frutaY = rnd.Next(2, (largura - 2));
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
                Console.WriteLine("_");
            }
            for (int i = 1; i <= (altura + 2); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");
            }
            for (int i = 1; i <= (altura + 2); i++)
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
            if (x[0] == frutaX)
            {
                if (y[0] == frutaY)
                {
                    cobra++;
                    frutaX = rnd.Next(2, (altura - 2));
                    frutaY = rnd.Next(2, (largura - 2));
                }
            }
            for(int i = cobra; i > 1; i--)
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
            for(int i =0;i<=(cobra-1); i++)
            {
                WritePoint(x[i], y[i]);
                WritePoint(frutaX, frutaY);
            }
        }

        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x = 0,y = 0);
            Console.Write("*");
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
            Console.ReadKey();
        }
    }
}

