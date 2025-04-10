// Write a program that extracts from a text all dates written in format 
// DD.MM.YYYY and prints them on the console in the standard format for 
// Canada. Sample text: 
// I was born at 14.06.1980. My sister was born at 3.7.1984. In 
// 5/1999 I graduated my high school. The law says (see section 
// 7.3.12) that we are allowed to do this (section 7.4.2.9). 
// Extracted dates from the sample text: 
// 14.06.1980 
// 3.7.1984

using System.Text.RegularExpressions;

class Dates
{
    static void Main()
    {
        // string s = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        
        Console.WriteLine("Program to extract dates from given string.");
        Console.WriteLine("Dates are in format dd.mm.yyyy");
        string s = GetString("Enter text: ");

        // pattern to match dates in format dd.mm.yyyy where
        // date and month can be 1 or 2 digit
        // \b\d{1,2} - to match dd at word boundary
        // \.\d{1,2}\. - to match month
        // \d{4}\b - to match year at word boundary
        string pattern = @"\b\d{1,2}\.\d{1,2}\.\d{4}\b";
        Console.WriteLine();
        Console.WriteLine("Dates:");
        foreach(Match match in Regex.Matches(s, pattern))
        {
            Console.WriteLine(match);
        }
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
}