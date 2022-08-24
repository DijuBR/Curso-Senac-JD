using System;

namespace Descobrindo_o_objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string r, o;
            Console.WriteLine("Bem-Vindo(a) ao Descobrindo o Objeto \n" +
                "Dica: Usado para doces e líquidos");
            o = "COLHER";
            r = Console.ReadLine();
            if (r.ToUpper().Equals(o))
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Você errou \n" +
                    "Dica: Formato redondo seguido de algo reto de apoio para segurar");
            }

            r = Console.ReadLine();
            if (r.ToUpper().Equals(o))
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Você errou \n" +
                    "Dica: Tem várias versões");
            }

            r = Console.ReadLine();
            if (r.ToUpper().Equals(o))
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Você errou \n" +
                    "Dica: Serve pra um tipo de janta que maioria odeia");
            }

            r = Console.ReadLine();
            if (r.ToUpper().Equals(o))
            {
                Console.WriteLine("Acertou");
            }
            else
            {
                Console.WriteLine("Você errou \n" +
                    "Dica: Café, sopa e chá");
                r = Console.ReadLine();
            }
            Console.WriteLine("Fim de jogo, a resposta era: " + o);
        }
    }
}
