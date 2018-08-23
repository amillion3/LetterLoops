using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string.");
            string inputString = Console.ReadLine();
            char[] splitChars = inputString.ToCharArray();
            foreach (var letter in splitChars)
            {
                Console.WriteLine($"Letter: {letter}");
            }

            Console.WriteLine(splitChars[0]);
            Console.ReadLine();
        }
    }
}
