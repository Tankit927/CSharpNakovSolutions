// How many backslashes you must specify as an argument to the method 
// Split(…) in order to split the text by a backslash? 
// Example: one\two\three.
// Note: In C# backslash is an escaping character.

class UsingSplitMethod
{
    static void Main()
    {
        Console.WriteLine("Program to split given string by given character");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        char c = GetChar("Enter splitting character: ");

        Console.WriteLine();
        SplitAndPrintSubstrings(s,c);
    }


    static char GetChar(string prompt)
    {
        // Method to user input character

        char c;
        bool isChar;

        do
        {
            Console.Write(prompt);
            isChar = char.TryParse(Console.ReadLine(), out c);
            if(!isChar)
            {
                Console.WriteLine("\nEnter a valid character");
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


    static void SplitAndPrintSubstrings(string s, char c)
    {
        // Method to split given string s using char c
        // and printing each substring

        string[] myArray = s.Split(c);

        foreach(string substring in myArray)
        {
            Console.Write($"{substring} ");
        }
    }
}