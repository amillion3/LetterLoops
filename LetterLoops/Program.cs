using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string.");
            string inputString = Console.ReadLine().ToUpper();
            var splitChars = inputString.ToCharArray(); // split string to char array
            string finalString = "";
            int count = 1; // Incremented each time another letter is examined

            // Loop through each letter and apply styling
            foreach (var letter in splitChars)
            {
                string a = letter.ToString();
                if (count == 1) // First letter only
                {
                    finalString += $"{a}-";
                }
                else // Second letter and up
                {
                    finalString += a; // capital first letter...
                    string b = a.ToLower();  // now all following are lowercase.
                    for (var j = 1; j < count; j++)
                    {
                        finalString += b;
                    }
                    finalString += "-"; // add a dash at the end of each letter examination
                }
                count++; // increase count
            }
            // trim trailing  -  from end of string
            string finalTrimmedString = finalString.TrimEnd('-');

            Console.WriteLine(finalTrimmedString);
            Console.ReadLine();
        }
    }
}
