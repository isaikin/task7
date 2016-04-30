using System;
using System.Text.RegularExpressions;

namespace _7._4_NUMBER_VALIDATOR
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string input = "112.12";
            string engineerFormNumberPattern = @"\b[+-] ? 0 *[1 - 9](\.\d +) ? (?: E | e)[+-]?[1 - 9]\d *\b";
            string simpleNumberPattern = @"^[+-]?\d+(?:\.\d+)?$";

            var resultEngineerFormNumberPattern = Regex.Matches(input,engineerFormNumberPattern);
            var resultsimpleNumberPattern= Regex.Matches(input, simpleNumberPattern);

            if (Regex.IsMatch(input, engineerFormNumberPattern))
            {
                Console.WriteLine("Это число в инженерной нотации!");
            }
            else if (Regex.IsMatch(input, simpleNumberPattern))
            {
                Console.WriteLine("Это число в обычной нотации!");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
        }
    }
}