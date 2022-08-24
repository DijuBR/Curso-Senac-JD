using System;

namespace Número_Inteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = int.Parse(Console.ReadLine());
            double antecessor = (inteiro - 1);
            double sucessor = (inteiro + 1);
            double dobro = (inteiro * 2);
            double metade = (inteiro / 2);
            
            Console.WriteLine("Inteiro: " + inteiro);
            Console.WriteLine("Antecessor: " + antecessor);
            Console.WriteLine("Sucessor: " + sucessor);
            Console.WriteLine("Dobro: " + dobro);
            Console.WriteLine("Metade: " + metade.ToString("N2"));

        }
    }
}
