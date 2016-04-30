using System;
using System.Text.RegularExpressions;

namespace _7._2_HTML_REPLACER
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = @"<b class=""buttom""> Это </b> текст <i> с </i> <font color=""red"">HTML</font> кодами";
            string pattern = @"(<(?:\/?\w+(?:\s*(\w+)\s*=\s*""\w+"")*)>|<(?:\w+\/?)>)";
            string q = Regex.Replace(text, pattern, "_");
            Console.WriteLine(q);
        }
    }
}