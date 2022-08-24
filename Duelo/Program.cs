using System;

namespace Duelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string p1, p2;
            int pow1, mag1, res1, pow2, mag2, res2;

            Console.WriteLine("Insira o nome do player 1:");
            p1 = Console.ReadLine();
            pow1 = r.Next((10), (101));
            mag1 = r.Next((10), (101));
            res1 = r.Next((10), (101));



            Console.WriteLine("Insira o nome do player 2:");
            p2 = Console.ReadLine();
            pow2 = r.Next((10), (101));
            res2 = r.Next((10), (101));
            mag2 = r.Next((10), (101));

            Console.WriteLine(p1 + "     VS     " + p2);
            Console.WriteLine("Poder: " + (pow1) + "     VS     " + "Poder: " + (pow2));
            Console.WriteLine("Magia: " + (mag1) + "     VS     " + "Magia: " + (mag2));
            Console.WriteLine("Resis: " + (res1) + "     VS     " + "Resis: " + (res2));

            if(pow1 >pow2)
            {
                Console.WriteLine(p1 + " Venceu em poder!");
            }
            else
            {
                if (pow2 > pow1)
                {
                    Console.WriteLine(p2 + " Venceu em poder!");
                }
                else
                {
                    Console.WriteLine("Empatou em poder!");
                }
            }

            if (mag1 > mag2)
            {
                Console.WriteLine(p1 + " Venceu em magia!");
            }
            else
            {
                if (mag2 > mag1)
                {
                    Console.WriteLine(p2 + " Venceu em magia!");
                }
                else
                {
                    Console.WriteLine("Empatou em magia!");
                }
            }

            if (res1 > res2)
            {
                Console.WriteLine(p1 + " Venceu em resistência!");
            }
            else
            {
                if (res2 > res1)
                {
                    Console.WriteLine(p2 + " Venceu em resistência!");
                }
                else
                {
                    Console.WriteLine("Empatou em resistência!");
                }
            }





        }
    }
}
