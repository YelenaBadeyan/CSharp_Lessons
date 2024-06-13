using System;

namespace ArrayMemoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example 1 Creating Array from integers

            int[] intArray = new int[1000000];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 10; 
            }


            //Example 2 Creating arrag from strings

            string[] stringArray = new string[1000000];

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = "String number " + i; 
            }

            Console.WriteLine("String array was created");

            Console.ReadLine(); 
        }
    }
}
