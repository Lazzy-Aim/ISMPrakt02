using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;

            Console.WriteLine("Enter number - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number - b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number - c");
            c = Convert.ToDouble(Console.ReadLine());

            d = Math.Pow(b, 2) - (4 * a * c);

            if (d > 0)
            {
                x1 = (-b + (4 * a * c)) / (2 * a);
                x2 = (-b - (4 * a * c)) / (2 * a);

                Console.WriteLine("First root:");
                Console.WriteLine(x1);
                Console.WriteLine("Second root:");
                Console.WriteLine(x2);
            }
            else if (d == 0)
            {
                x1 = (-b + (4 * a * c)) / (2 * a);

                Console.WriteLine("Root:");
                Console.WriteLine(x1);
            }
            else
            {
                Console.WriteLine("Equation doesn't have roots");
            }

            Console.ReadKey();
        }
    }
}
