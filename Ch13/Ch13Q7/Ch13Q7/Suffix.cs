// Write a program that reads a string from the console (20 characters 
// maximum) and if shorter complements it right with "*" to 20 characters.

class Suffix
{
    static void Main()
    {
        Console.WriteLine("Program to add a character to right of"
        + " given string if " +
        "its length is shorter than given length");
        string s = GetString("Enter string: ");
        Console.WriteLine();

        char c = GetChar("Enter character: ");
        Console.WriteLine();

        int len = GetInt("Length: ");
        Console.WriteLine();

        PrintWithSuffix(s, c, len);
        Console.WriteLine(s);
        s = s.PadRight(len, c);
        Console.WriteLine(s);
    }


    static int GetInt(string prompt, int? min=null, int? max=null)
    {
        // Method to user input integer

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || max != null && num > max)
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || max != null && num > max);

        return num;
    }


    static char GetChar(string prompt)
    {
        // Method to user input char

        char c;
        bool isChar;

        do
        {
            Console.Write(prompt);
            isChar = char.TryParse(Console.ReadLine(), out c);
            if(!isChar)
            {
                Console.WriteLine($"\nEnter a valid character");
            }
        }
        while(!isChar);

        return c;
    }


    static string GetString(string prompt)
    {
        // Method to user input string

        string s;

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


    static void PrintWithSuffix(string s, char suffix, int len=20)
    {
        // Method to suffix the given string with given suffix char
        // if length of string is less than len

        Console.WriteLine(s.PadRight(len, suffix));
    }
}