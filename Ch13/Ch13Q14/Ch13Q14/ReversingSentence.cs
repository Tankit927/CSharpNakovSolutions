// Write a program that reverses the words in a given sentence without 
// changing punctuation and spaces. For example: "C# is not C++ and 
// PHP is not Delphi" --> "Delphi not is PHP and C++ not is C#".

using System.Text;

class ReversingSentence
{
    static void Main()
    {
        Console.WriteLine("Program to reverse a given sentence");
        string s = GetString("Enter something: ");

        Console.WriteLine();
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(ReverseSentence(s));
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


    static string ReverseSentence(string s)
    {
        // Method to reverse given sentence

        string[] words = s.Split(' ');
        int len = words.Length;

        StringBuilder sb = new();

        for(int i = len-1; i >= 0; i--)
        {
            sb = sb.Append(words[i]);
            if(i > 0)
            {
                sb = sb.Append(' ');
            }
        }

        return sb.ToString();
    }
}