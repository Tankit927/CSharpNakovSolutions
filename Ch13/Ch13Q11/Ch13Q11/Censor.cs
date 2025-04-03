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

class Censor
{
    static void Main()
    {
        Console.WriteLine("Program to censor certain words in the given string");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        string forbiddenWords = GetString("Enter comma separated forbidden words: ");

        Console.WriteLine();
        Console.WriteLine("Given text:");

        Console.WriteLine();
        Console.WriteLine("Censored text:");
        Console.WriteLine(CensorWords(s, forbiddenWords));
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