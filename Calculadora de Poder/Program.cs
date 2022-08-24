using System;

namespace Calculadora_de_Poder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual seu poder?");
            double poder = double.Parse(Console.ReadLine());
            double magia = (10 - poder) / 2;
            double resistencia = (10 - poder);
            double inteligencia = r.NextDouble()*10;
         
            Console.WriteLine("Seu nome é: " + nome+ "!");
            Console.WriteLine("Seu poder é: " + poder.ToString("N2"));
            Console.WriteLine("Sua magia é: " + magia.ToString("N2"));
            Console.WriteLine("Sua Resistência é: " + resistencia.ToString("N2"));
            Console.WriteLine("Sua inteligência é: " + inteligencia.ToString("N2"));


        }
    }
}
