// Write a program that extracts from a text all words which are 
// palindromes, such as ABBA", "lamal", "exe".

using System.Text;

class Palindromes
{
    static void Main()
    {
        Console.WriteLine("Program to find all palindromes in given string");
        string s = GetString("Enter text: ");

        string[] palindromes = ExtractPalindromes(s);
        Console.WriteLine();
        Console.Write("Palindromes: ");
        PrintArray(palindromes);
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


    static void PrintArray(string[] myArray)
    {
        // Method to print given array

        foreach(string s in myArray)
        {
            if(!string.IsNullOrWhiteSpace(s))
            {
                Console.Write($"{s} ");
            }
        }

        Console.WriteLine();
    }


    static string[] ExtractPalindromes(string s)
    {
        // Method to extract all palindromes in given string

        const string SYMBOLS = " `~!@#$%^&*()_-+={}[]\\|;:'\",<.>/?";

        string[] words = s.Split(SYMBOLS.ToArray(), '.', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        string[] palindromes = new string[words.Length];

        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].Equals(Reverse(words[i]), StringComparison.InvariantCultureIgnoreCase))
            {
                palindromes[i] = words[i];
            }
        }

        return palindromes;
    }


    static string Reverse(string s)
    {
        // Method to reverse given string

        int len = s.Length;
        StringBuilder sb = new(len);

        for(int i = len-1; i >= 0; i--)
        {
            sb = sb.Append(s[i]);
        }

        return sb.ToString();
    }
}