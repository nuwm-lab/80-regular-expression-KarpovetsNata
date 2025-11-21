using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string text = "У цьому тексті є слова A1B2C3, test123, ABC, 456def, hello.";

        // Регулярний вираз: \b\w*\d\w*\b
        // \b - межа слова
        // \w* - будь-які буквено-цифрові символи 0 або більше разів
        // \d - хоч би одна цифра
        // \w* - будь-які буквено-цифрові символи 0 або більше разів
        // \b - межа слова
        Regex regex = new Regex(@"\b\w*\d\w*\b");

        MatchCollection matches = regex.Matches(text);

        Console.WriteLine("Слова з хоча б однією цифрою:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
