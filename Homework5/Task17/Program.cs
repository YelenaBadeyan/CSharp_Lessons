using System;

namespace TriangleTypeDetermination
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 5;

            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is scalene.");
            }
        }
    }
}
