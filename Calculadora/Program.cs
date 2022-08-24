using System;
//difícil demais :(
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resp;
            
            Console.WriteLine("Digite seu 1ºnúmero");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu 2ºnúmero");
            num2 = double.Parse(Console.ReadLine());

            resp = num1 + num2;
            Console.WriteLine("Soma: " + resp.ToString("N2"));
            resp = num1 - num2;
            Console.WriteLine("Sub: " + resp.ToString("N2"));
            resp = num1 * num2;
            Console.WriteLine("Mult: " + resp.ToString("N2"));
            resp = num1 / num2;
            Console.WriteLine("Div: " + resp.ToString("N2"));
        }
    }
}
