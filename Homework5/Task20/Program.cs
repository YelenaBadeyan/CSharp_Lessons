using System;

namespace LargestAndSmallestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 5;
            int c = 8;
            int d = 3;
            int e = 6; 

            int largest = a;

            if (b > largest)
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }

            if (d > largest)
            {
                largest = d;
            }

            if (e > largest)
            {
                largest = e;
            }

            int smallest = a;

            if (b < smallest)
            {
                smallest = b;
            }

            if (c < smallest)
            {
                smallest = c;
            }

            if (d < smallest)
            {
                smallest = d;
            }

            if (e < smallest)
            {
                smallest = e;
            }

            Console.WriteLine("The largest number is: " + largest);
            Console.WriteLine("The smallest number is: " + smallest);
        }
    }
}
