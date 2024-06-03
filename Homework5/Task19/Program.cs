using System;

namespace VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'a';

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine($"{ch} is a vowel.");
                    break;
                default:
                    Console.WriteLine($"{ch} is a consonant.");
                    break;
            }
        }
    }
}
