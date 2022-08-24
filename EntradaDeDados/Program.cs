using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double bonus;

            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();

            Console.Write("Digite a sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu bonus");
            bonus = double.Parse(Console.ReadLine());

            Console.WriteLine("Boa Noite " + nome + "!");
            Console.WriteLine("Você tem " + idade + "anos!");
            Console.WriteLine("Vôcê ganha" + bonus + "de bonus!");
        }
    }
}
