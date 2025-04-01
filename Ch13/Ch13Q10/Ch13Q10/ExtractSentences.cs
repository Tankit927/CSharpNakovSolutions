// Write a program that extracts from a text all sentences that contain 
// a particular word. We accept that the sentences are separated from 
// each other by the character "." and the words are separated from one 
// another by a character which is not a letter. 
// Sample text: 
// We are living in a yellow submarine. We don't have anything 
// else. Inside the submarine is very tight. So we are drinking 
// all the day. We will move out of it in 5 days. 
// Sample result: 
// We are living in a yellow submarine. 
// We will move out of it in 5 days.

using System.Text;

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Program to print sentences containing certain word");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        string word = GetString("Enter word: ");
        word = " " + word + " ";

        Console.WriteLine();
        Console.WriteLine($"Sentences containing given word {word}: ");
        Console.WriteLine(ExtractSentencesWithCertainWord(s, word));
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


    static string ExtractSentencesWithCertainWord(string s, string w)
    {
        // Method to extract sentences with certain word in it.
        // A sentence is anything within '.'

        const char C = '.';
        int len = s.Length;
        int index = s.IndexOf(w, StringComparison.InvariantCultureIgnoreCase);

        if(index < 0)
        {
            return string.Empty;
        }

        StringBuilder sb = new();

        do
        {
            int start = s.LastIndexOf(C, index);

            if(start < 0)
            {
                start = 0;
            }
            else
            {
                start += 1;
            }

            while(char.IsWhiteSpace(s[start]))
            {
                start += 1;
            }

            int end = s.IndexOf(C, index);

            if(end < 0)
            {
                end = len;
            }
            else
            {
                end += 1;
            }

            sb = sb.Append(s, start, end-start);
            sb = sb.AppendLine();
            index += 1;

            if(index > len)
            {
                break;
            }

            index = s.IndexOf(w, index, StringComparison.InvariantCultureIgnoreCase);
        }
        while(index >= 0);

        return sb.ToString();
    }
}