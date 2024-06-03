using System;

namespace LargestOfFourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 7;
            int d = 12;

            int largest;

            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        largest = a;
                    }
                    else
                    {
                        largest = d;
                    }
                }
                else
                {
                    if (c > d)
                    {
                        largest = c;
                    }
                    else
                    {
                        largest = d;
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        largest = b;
                    }
                    else
                    {
                        largest = d;
                    }
                }
                else
                {
                    if (c > d)
                    {
                        largest = c;
                    }
                    else
                    {
                        largest = d;
                    }
                }
            }

            Console.WriteLine("The largest number is: " + largest);
        }
    }
}
