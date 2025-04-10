// Write a program that reads a string from the console and replaces every 
// sequence of identical letters in it with a single letter (the repeating 
// letter). Example: "aaaaabbbbbcdddeeeedssaa" --> "abcdedsa".

using System.Text;

class NoRepetition
{
    static void Main()
    {
        Console.WriteLine("Program to replace all consecutive identical letters with");
        Console.WriteLine("single letters.");
        string s = GetString("Enter text: ");
        
        string withoutDuplicateLetters = RemoveConsecutiveDuplicateLetters(s);

        Console.WriteLine();
        Console.WriteLine("String with duplicate letters removed:");
        Console.WriteLine(withoutDuplicateLetters);
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


    static string RemoveConsecutiveDuplicateLetters(string s)
    {
        // Method to remove consecutive duplicate letters in given string
        // Example: "aaaaaaabbbbbbbcccccccddddddeeeeee" --> "abcde"

        StringBuilder sb = new(s);

        for(int i = 0; i < sb.Length-1; i++)
        {
            if(!char.IsLetterOrDigit(sb[i]))
            {
                continue;
            }

            for(int j = i+1; j < sb.Length;)
            {
                if(sb[i] == sb[j])
                {
                    sb = sb.Remove(j, 1);
                }
                else
                {
                    break;
                }
            }
        }

        return sb.ToString();
    }
}