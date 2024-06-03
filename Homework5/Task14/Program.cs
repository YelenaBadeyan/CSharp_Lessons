using System;

namespace AgeGroupClassificationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25; 

            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("Adult");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
        }
    }
}
