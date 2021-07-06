using System;

namespace Math_Operation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a Number");
            a = Convert.ToInt32(Console.ReadLine());
            b = a * 50;
            Console.WriteLine(b);

            int c, d;
            Console.WriteLine("Enter a Number");
            c = Convert.ToInt32(Console.ReadLine());
            d = c + 25;
            Console.WriteLine(d);

            double e, f;
            Console.WriteLine("Enter a Number");
            e = Convert.ToDouble(Console.ReadLine());
            f = e / 12.5;
            Console.WriteLine(f);

            int g;
            Console.WriteLine("Enter a Number");
            g = Convert.ToInt32(Console.ReadLine());
            if (g > 50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            double h, i;
            Console.WriteLine("Enter a Number");
            h = Convert.ToDouble(Console.ReadLine());
            i = h % 7;
            Console.WriteLine(i);
        }
    }
}
