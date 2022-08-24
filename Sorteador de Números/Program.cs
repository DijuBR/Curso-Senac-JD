using System;

namespace Sorteador_de_Números
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n1, n2, n3, ra;

            ra = r.Next((1), (11));

            Console.WriteLine("Chute1: ");
            n1 = int.Parse(Console.ReadLine());
          

            if (n1 == ra)
            {
                Console.WriteLine("Você acertou!");
                Console.WriteLine("Número: " + ra);
            }
            else
            {
                Console.WriteLine("Chute2: ");
                n2 = int.Parse(Console.ReadLine());
                if (n2 == ra)
                {
                    Console.WriteLine("Você acertou!");
                    Console.WriteLine("Número: " + ra);
                }
                else
                {
                    Console.WriteLine("Chute3: ");
                    n3 = int.Parse(Console.ReadLine());
                    if (n3 == ra)
                    {
                        Console.WriteLine("Você acertou!");
                        Console.WriteLine("Número: " + ra);
                    }
                    else
                    {
                        Console.WriteLine("Game over" + "O número foi: " + ra);
                    }
                }

            }


        }
    }
}
