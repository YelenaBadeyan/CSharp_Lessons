using System;

namespace ArrayMemoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 2, 2, 3, 3, 4, 4, 4, 4, 4};
            int finalStartIndex = 0;
            int finalLength = 0;
            int currentStartIndex = 0;
            int currentLength = 0;

            for (int i = 0; i < ints.Length-1; i++)
            {
                if (ints[i] == ints[i + 1]) { 
                    currentStartIndex = i;
                    currentLength += 1; }
                else
                {
                    if(currentLength > finalLength)
                    {
                        finalLength = currentLength;
                        finalStartIndex = currentStartIndex;
                    }
                }
            }
            Console.WriteLine(finalStartIndex) ; 
            Console.WriteLine(finalLength) ;
        }
     
    }
}
