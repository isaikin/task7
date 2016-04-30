using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7._3_EMAIL_FINDER
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pattern = @"(((?:[a-z/d]|[A-Z/d])[_]?([a-z/d}|[A-Z/d]\.)*)+@(?:[a-z/d.]|[A-Z/d.])*[a-z]{2,6})";
            string text = "Иван: ivan@mail.ru, Петр: p_ivanov@mail.rol.ru";
            var mails = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            foreach (var q in mails)
            {
                Console.WriteLine(q);
            }
        }
    }
}