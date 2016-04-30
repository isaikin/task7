using System.Text.RegularExpressions;

namespace _7._1_DATE_EXISTANCE
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @"(((?:0[1-9]|[12][0-9]|3[01])-(?:0[13578]|1[02])-(?:\d{4}))|((?:0[1-9]|1[0-9]|2[0-9])-02-\d{4}) )|((?:0[1-9]|[12][0-9]|30)-(?:0[469]|11)-\d{4})";
            string text ="31-12-1995";
            System.Console.WriteLine(Regex.IsMatch(text, pattern) ? "В заданном тексте содержится дата" : "В заданном тексте отсутствуют даты!");
        }
    }
}