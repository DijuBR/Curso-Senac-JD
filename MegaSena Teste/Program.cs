using System;

namespace MegaSena_Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BEM VINDO AO MEGASENA CRACKEADO 100%FUNCIONAL 2022 PT-BR V1.32 \n" + "Os seus números da megasena são:");
            Random r = new Random();
            Console.WriteLine("Número 1:" + r.Next((0),11));
            Console.WriteLine("Número 2:" + r.Next((11),21));
            Console.WriteLine("Número 3:" + r.Next((21), 31));
            Console.WriteLine("Número 4:" + r.Next((31), 41));
            Console.WriteLine("Número 5:" + r.Next((41), 51));
            Console.WriteLine("Número 6:" + r.Next((51), 61));
        }
    }
}
