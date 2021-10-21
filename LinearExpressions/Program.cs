using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x, y, z, r;

            Console.WriteLine("Enter number - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number - b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number - c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number - d");
            d = Convert.ToDouble(Console.ReadLine());

            x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - (Math.Pow(a, 2)) / (Math.Pow(b, 2));
            y = (5 * (a + b) * (c - d)) / ((1 / 2) * c) + Math.Pow(d, 2) * ((Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a));
            z = ((Math.Pow((Math.Pow(x, 2) - 2 * x), 3)) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
            r = ((1 / 2) * a + (3 / 4) * b - (7 / 5)) / (3 * c + 1) + (1) / (a - c);

            Console.WriteLine("Result x:");
            Console.WriteLine(x);
            Console.WriteLine("Result y:");
            Console.WriteLine(y);
            Console.WriteLine("Result z:");
            Console.WriteLine(z);
            Console.WriteLine("Result r:");
            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
