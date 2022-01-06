using System;

namespace Baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Write("a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            c = double.Parse(Console.ReadLine());


            delta = Math.Pow(b, 2.0) - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("O valor de delta é: " + delta);
            Console.WriteLine("O valor de x1 é: " + x1);
            Console.WriteLine("O valor de x2 é: " + x2);
            
        }
    }
}
