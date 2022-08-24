using System;

namespace Perguntas_e_Respostas
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta, A, B, C, D, E, p1, p2, p3, p4, p5;
            int pontuação = 0;
            Console.WriteLine("Bem-vindo(a), ao jogo de perguntas e respostas!");


            /*Console.WriteLine(nome.Equals("SENAC"));
             Console.WriteLine(nome.ToUpper().Equals("SENAC"));
             Console.WriteLine(nome.Contains("A"));
             Console.WriteLine(nome.ToUpper().Contains("A"));
             Console.WriteLine(nome.IndexOf("A"));
             Console.WriteLine(nome.ToUpper().IndexOf("A"));*/


            Console.WriteLine("1- Como é o nome do jogo? \n" +
                "A) Minecraft \n" +
                "B) Perguntas e Respostas \n" +
                "C) perguntas e respostas \n" +
                "D) League of Legends 2 \n");

            Console.WriteLine("\n" +
                "Resposta:");
            resposta = Console.ReadLine();
            if (resposta.ToUpper().Equals("B"))
            {
                Console.WriteLine("Você acertou");
                pontuação = 0 + 10;
            }
            else{
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("2- Say my name \n" +
              "A) Heinsenberg \n" +
              "B) João Pedro \n" +
              "C) Diju \n" +
              "D) Cornelius \n");

            Console.WriteLine("\n" +
                "Resposta:");
            resposta = Console.ReadLine();
            if (resposta.ToUpper().Equals(("D")))
            {
                Console.WriteLine("Você acertou");
                pontuação = pontuação + 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("3- Meu jogo favorito: \n" +
              "A) Minecraft \n" +
              "B) Risk of Rain 2 \n" +
              "C) League of Legends \n" +
              "D) Plants vs Zombies Garden Warfare \n");

            Console.WriteLine("\n" +
                "Resposta:");
            resposta = Console.ReadLine();
            if (resposta.ToUpper().Equals("A"))
            {
                Console.WriteLine("Você acertou");
                pontuação = pontuação + 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("4- Meu amigo favorito do curso: \n" +
              "A) Paulo \n" +
              "B) Pedro \n" +
              "C) Lucas \n" +
              "D) Gabriel \n");

            Console.WriteLine("\n" +
                "Resposta:");
            resposta = Console.ReadLine();
            if (resposta.ToUpper().Equals(("D")))
            {
                Console.WriteLine("Você acertou");
                pontuação = pontuação + 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("5- Minha comida favorita: \n" +
              "A) Tabule \n" +
              "B) Nhoque \n" +
              "C) Lasanha \n" +
              "D) Churros \n");

            Console.WriteLine("\n" +
                "Resposta:");
            resposta = Console.ReadLine();
            if (resposta.ToUpper().Equals("C"))
            {
                Console.WriteLine("Você acertou");
                pontuação = pontuação + 10;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Resultado: " + pontuação);


        }
    }
}
