// Write a program that reads a list of words separated by commas from the 
// console and prints them in alphabetical order (after sorting).

class SortedWords
{
    static void Main()
    {
        Console.WriteLine("Program to print words in alphabetical order when");
        Console.WriteLine("word list of comma separated words is given.");
        string s = GetString("Enter comma separated words: ");

        string[] sortedList = SortWords(s);

        Console.WriteLine();
        foreach(string word in sortedList)
        {
            Console.Write($"{word} ");
        }

        Console.WriteLine();
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


    static string[] SortWords(string s)
    {
        // Method to sort comma separated words in a given string

        string[] wordList = s.Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
        SortStrings(wordList);
        
        return wordList;
    }


    static void SortStrings(string[] wordList)
    {
        // Method to sort given wordList

        int len = wordList.Length;

        for(int i = 0; i < len-1; i++)
        {
            for(int j = i+1; j < len; j++)
            {
                if(string.Compare(wordList[j], wordList[i]) < 0)
                {
                    string temp = wordList[i];
                    wordList[i] = wordList[j];
                    wordList[j] = temp;
                }
            }
        }
    }
}