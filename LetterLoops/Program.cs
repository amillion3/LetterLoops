using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string.");
            string inputString = Console.ReadLine().ToUpper();
            var splitChars = inputString.ToCharArray();
            string finalString = "";
            int count = 1;

            foreach (var letter in splitChars)
            {
                string a = letter.ToString();
                int i = 0;
                if (count == 1)
                {
                    finalString += $"{a}-";
                } else
                {
                    finalString += a;
                    string b = a.ToLower();
                    for (var j = 1; j < count; j++)
                    {
                        finalString += b;
                    }
                    finalString += "-";
                }
                count++;
            }
            string finalTrimmedString = finalString.TrimEnd('-');

            Console.WriteLine(finalTrimmedString);
            Console.ReadLine();
        }
    }
}
