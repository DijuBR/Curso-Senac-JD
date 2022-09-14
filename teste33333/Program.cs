using System;
using System.Threading;

namespace teste33333
{
    class Snake
    {
        //TAMANHO DA TELA
        int altura = 21; //Altura da tela
        int largura = 51; //Largura da tela

        string resp;
        string turbo = "não";

        int[] x = new int[1070];
        int[] y = new int[1070];

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
            if(cobra > 60)
            {
                turbo = "Sim";
            }
            Console.WriteLine("TURBO: " + turbo);
            Console.WriteLine("TAMANHO: " + cobra);
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
                    Console.WriteLine("Perdeu!!!!!!!!!");
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
            if (cobra < 60)
            {
                Thread.Sleep(200 - (3 * cobra));
            }
            else
            {
                Thread.Sleep(20);
            }
           
        }

        public void WritePoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("█");
        }
        static void Main(string[] args)
        {
            string continua = "sim";
            while (continua.Equals("sim"))
            {
                Console.ResetColor();
                Console.Clear();
                Snake.start();
                Snake snake = new Snake();
                while (!snake.derrota)
                {
                    snake.WriteBoard();
                    snake.Input();
                    snake.Logic();
                }
                if (snake.derrota)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@" 
_____ ______   ________  ________  ________  _______   ___  ___  ___       
|\   _ \  _   \|\   __  \|\   __  \|\   __  \|\  ___ \ |\  \|\  \|\  \      
\ \  \\\__\ \  \ \  \|\  \ \  \|\  \ \  \|\  \ \   __/|\ \  \\\  \ \  \     
 \ \  \\|__| \  \ \  \\\  \ \   _  _\ \   _  _\ \  \_|/_\ \  \\\  \ \  \    
  \ \  \    \ \  \ \  \\\  \ \  \\  \\ \  \\  \\ \  \_|\ \ \  \\\  \ \__\   
   \ \__\    \ \__\ \_______\ \__\\ _\\ \__\\ _\\ \_______\ \_______\|__|   
    \|__|     \|__|\|_______|\|__|\|__|\|__|\|__|\|_______|\|_______|   ___ 
                                                                       |\__\
                                                                       \|__|"
                                                                                 + "\nPontuação:" + snake.pontos);
                    Console.WriteLine("Deseja continuar novamente?");
                    continua = Console.ReadLine();
                

                }
            }
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
            Console.WriteLine("A partir do tamanho da cobra ser maior que 60 não vai aumentar a velocidade");
            Console.WriteLine("AVISO: NÃO JOGUE SE TIVER PROBLEMAS COM ATAQUE EPILÉTICO, EPILEPSIA E ESSAS COISAS");
            Console.WriteLine("A EQUIPE NÃO SE RESPONSABILIZA POR DAUNOS CAUSADOS A QUEM FOR TESTAR O NOSSO JOGO!");
            Console.WriteLine(@"

▓▓╣▓╫▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▌░           `'░░░¡¡└░░░▒▒▒▒▒╢╢▓▓▓▓█████████████▒╫▓▓▓▓▓▓▓▓▓▓

╣▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╣M            `'``''`░░░▒▒▒▒▒╢╫▓▓▓▓█████████████▓▓╢▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓└`              ````┌¡░░░▒▒▒╫╬▓▓▓▓▓▓▓▓████████████▌╣▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╢                `'┌░░░░░▒▒▒▒▒╢▓▓███▓▓▓▓███████████▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒             .```¡¡░░░░▒▒▒▒▒▒▒▒▒▓█████▓▓██████████▓▓▒╫▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░          '''``````      `└░░░░░▒▒▒▓▓▓▓▓███████████▓╣▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓H`         ```,`'```   ,,,,..    ''╜╜▒╜╢▒▓▓▓▓▓███████▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒r         `''¡¡¡`````'''░░░░░¡`    ```└░▒╢╣▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░',`      '````└'```    `'░░╜`   ` ``   ,,░▒▒▒▒░░░╝╢▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▌╙``¿┐¡,.    :````'``           ;┐     ``  ╓g▓▒▒░░`  .┌«╥╥╥▒▒╢▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓░░ ░░░░└¡``` ``````'``,'`     ,┌░▒▒Ü░¡¡,,░░╢▓▓█▓╢`    ¡░▒▓▓▓▓▓╣▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓╢~'`````   ```````'┌░░░░░@g▄▄▄▒▒▒▒▒▒▒▒▒▒▒▓█████╖/   ╙╜╜╢▒╢▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▌░```┌¡░,`:``  `┌¡````'¡░░░▒▒╫▓▓█████▓▓╣▒▒▒▒▒╢█████▓▌m;;;..'░░╢╫▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▌░~` ░░¡'''``  `└¡¡¡````¡└░░▒╢▓▓█████▓▒▒░▒░▒▓▓███████▓░░,░░▒▒▒▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▌╢~ `¡░¡`````  `''¡`````''░░░╜╜▒▒▀▀▀▀▀▒░▒▒▓▓▓▀██████████▌▄▄▓▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▒░░░░░░,``    ``````````````└░░░░░░````└░└└`░░▒▓▓███████████▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▄░░¡`.``      `'`````````'¡░░░░'`        `  '└╙╨╨▀█████▓▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓@m¡¡~`` `  ``````` `:¡¡░░░░`````````         '░▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╣Ü¡¡`           ````''¡░░`      ,       ,;;▒▓▓▓╢╢╢╣╢▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░└¡░            ```'''''`  ``'''░░╖╖╖╖╖▓▒▒▓▓█▓▓╢╢╣▓▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒░¡¡¡`               `               `░░░▒╣╢▒▒▒▓▓▓╣╫▓▓▓▓▓▓▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░''```                      .,╓╓╓╓,,,,,,`''╜╨╜▓▓▓╣╫█▓█▓██▓▓▓▓▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░```'```                .:, ``└╙▀▓▓██████@╖``'║▒▒╢╫▓▓▓▓██████▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╣,`` `                 ```,` `       └░▒╢╫▓▓▓╣▒,▒▒▒▓▓▓▓▓▓██████▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░,`                    `¡░,```         .╖╫▓▓▌░░░▓▓▓▓▓▓███████▓▓

▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒░=                   `¡¡░`    ░¡,,¡r%@╫▓▓╣▒░▒▒▓▓▓▓▓▓███▓█▓█▓▓

▓▓▓▓▓▓▌╝^''░▒░▒░░░░░░░,,      µ▄▒H┘   .,▄..`░░█▒░▒╫▓▓▓▓▓▓▓▓▓░░░▓▓▓▓▓▓▓▓█▓▓▓█▓▓▓▓

▓▓▓▓▓╙`    ''░░░░└└'' ..   ▀▀▀     ╣██▒[ └╙▀╜╙░░╙╙╙╙╙╙▀╙▒░░╙╙╙╙╙╙▀▓███▓▓███▓▓

▓▓▓░░░██▓████▓∩ ,╟▓█████¡~'¡▐██████,]▒█████║╬╫█▓╣ j▒█████▒░  ]▓█████░▒▒▓██████▓▓

╙   ░████▀███▒╖▓██▀▀▀███W ███▓╢▓███Ü███▀▀╟▒█▓▒╖▐███╜▀▀█▌░▒██▀▀▀███▌¡▓██████▓▓

     ░██▓▌ ╟██▌▒███░░.███▌░██████▓▓▓∩ ▓██░r ╟▒█▌▒▒██▒╣:``└` ███░░░███▌└╙╙╙╙╙▓▓▓▓

     ░███▌▄███▒╜▓██▒▄▄███U ███▄▄▄█▓▓∩ ▓██▒▄.╟▒█▌▒╜▐██▓╓║██▌╜▓██▓▄▄███▌ ▓▓█▒░▓▓▓▓

     ░███████▀` `▀▀████▀╙¡¿╙▀▀████▀╙` ╙▀███░▒▒█▒░¿░▀█████▀▒╥░░▀█████▀\,▀▓█░░▓▓▓▓

    '░██▓▌            ¡└░▒▒░░¡   ,¡░░░,       ,░░▓▌╢░░░░░╢▓▓█▌▒░░░░▒▓▓▓▒░▒▒▒▓▓▓▓

,. `'▀▀▀Γ         '░░░░░░░░░░░░░░░░░░░░╓,,.░░▒████▓▓▓▓▓▓▓▓███▓▓▓██▓███████████▓

░░.  .'`            '░░░░░░░░░░░░░░░░▒▒▒╣▓▌░▒▒█████▓▓▓▓▓▓▓▓████████▓██████████▓▓");
            Console.ReadLine();


        }
    }
}

