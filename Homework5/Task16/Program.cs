using System;

namespace SmallestOfFourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z = 7;
            int w = 12;

            int smallest;

            if (x < y)
            {
                if (x < z)
                {
                    if (x < w)
                    {
                        smallest = x;
                    }
                    else
                    {
                        smallest = w;
                    }
                }
                else
                {
                    if (z < w)
                    {
                        smallest = z;
                    }
                    else
                    {
                        smallest = w;
                    }
                }
            }
            else
            {
                if (y < z)
                {
                    if (y < w)
                    {
                        smallest = y;
                    }
                    else
                    {
                        smallest = w;
                    }
                }
                else
                {
                    if (z < w)
                    {
                        smallest = z;
                    }
                    else
                    {
                        smallest = w;
                    }
                }
            }

            Console.WriteLine("The smallest number is: " + smallest);
        }
    }
}
