using System;

namespace Aula_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Teste 1:" + r.Next());
            Console.WriteLine("Teste 2:" + r.Next(10));
            Console.WriteLine("Teste 3:" + r.Next(10));
            Console.WriteLine("Teste 4:" + r.Next((10),21));
            Console.WriteLine("Teste 5:" + r.Next((10),21));
            Console.WriteLine("Teste 6:" + r.Next((10),21));
            Console.WriteLine("Teste 7:" + r.Next((10),21));
        }
    }
}
