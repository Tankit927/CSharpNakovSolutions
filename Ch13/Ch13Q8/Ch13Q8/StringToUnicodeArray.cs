// Write a program that converts a given string into the form of array of 
// Unicode escape sequences in the format used in the C# language. 
// Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".

class StringToUnicodeArray
{
    static void Main()
    {
        Console.WriteLine("Program to convert given string to unicode");
        Console.WriteLine("character array");

        string s = GetString("Enter string: ");
        Console.WriteLine();

        char[] charArray = s.ToCharArray();
        PrintCharArray(charArray);
    }


    static void PrintCharArray(params char[] myArray)
    {
        // Method to print given char array
        // in unicode format

        foreach(char c in myArray)
        {
            Console.Write($"\\u{(ushort)c:x4}");
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
}