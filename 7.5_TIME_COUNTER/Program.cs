using System;
using System.Text.RegularExpressions;

namespace _7._5_TIME_COUNTER
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = "В 7:55 я встал, позавтракал и к 10:56 пошёл на работу 00:12 12::12 00::00 1212:00 9:12 33:12 09:12 ";
            string pattern = @"\b(:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]";
            var collection = Regex.Matches(text, pattern);
            Console.WriteLine(collection.Count);
        }
    }
}