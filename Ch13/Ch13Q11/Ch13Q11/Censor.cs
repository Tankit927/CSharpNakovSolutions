// A string is given, composed of several "forbidden" words separated by 
// commas. Also a text is given, containing those words. Write a program 
// that replaces the forbidden words with asterisks. 
// Sample text: 
// Microsoft announced its next generation C# compiler today. 
// It uses advanced parser and special optimizer for the 
// Microsoft CLR. 
// Sample string containing the forbidden words: "C#,CLR,Microsoft". 
// Sample result: 
// ********* announced its next generation ** compiler today. 
// It uses advanced parser and special optimizer for the 
// ********* ***.

using System.Text;
using System.Text.RegularExpressions;

class Censor
{
    static void Main()
    {
        Console.WriteLine("Program to censor certain words in the given string");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        string forbiddenWords = GetString("Enter comma separated forbidden words: ");

        Console.WriteLine();
        Console.WriteLine("Censored text manually:");
        Console.WriteLine(CensorWords(s, forbiddenWords));

        string pattern = GetPattern(forbiddenWords);
        MatchCollection matches = Regex.Matches(s, pattern);
        string censored = Regex.Replace(s, pattern, m => new string('*', m.Length));
        Console.WriteLine();
        Console.WriteLine("Censored using regex:");
        Console.WriteLine(censored);
    }


    static string GetPattern(string commaSepWords)
    {
        // Method to generate regex pattern from comma separated words
        // pattern: @"(?i:\b{word}\b)"

        StringBuilder sb = new();
        int count = 1;

        foreach(string word in commaSepWords.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
        {
            if(count > 1)
            {
                sb = sb.Append('|');
            }
            if(IsAlphaNumericOrUnderscore(word[0]))
            {
                sb = sb.Append(@"(?i:\b");
            }
            else
            {
                sb = sb.Append(@"(?i:\B");
            }

            if(IsAlphaNumericOrUnderscore(word[^1]))
            {
                sb = sb.Append($@"{word}\b)");
            }
            else
            {
                sb = sb.Append($@"{word}\B)");
            }

            count += 1;
        }

        return sb.ToString();
    }


    static bool IsAlphaNumericOrUnderscore(char c)
    {
        // Method to determine whether given character is alphanumeric or underscore

        return char.IsLetterOrDigit(c) || c == '_';
    }


    static string GetString(string prompt)
    {
        // Method to user input string

        string? s;

        do
        {
            Console.Write(prompt);
            s = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("\nEnter something bruh!");
            }
        }
        while(string.IsNullOrWhiteSpace(s));

        return s;
    }


    static string CensorWords(string s, string forbidden)
    {
        // Method to censor all comma separated forbidden words in given string

        string[] forbiddenWords = forbidden.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new(s);

        for(int i = 0; i < forbiddenWords.Length; i++)
        {
            sb = sb.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }

        return sb.ToString();
    }
}