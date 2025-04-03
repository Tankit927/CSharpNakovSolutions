// Write a program that reads a string from the console and prints in 
// alphabetical order all letters from the input string and how many 
// times each one of them occurs in the string.
//
// Ch13Q23 is literally same lol.

class Letters
{
    static void Main()
    {
        Console.WriteLine("Program to print all letters from the given string");
        Console.WriteLine("and how many times each of them occurs.");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        int[] letterOccurances = GetAllLettersIn(s);
        const int PAD = 10;
        const int PAD2 = 20;
        Console.Write("|"); Console.Write(PadBothByLength("Letters", PAD)); Console.Write("|"); Console.Write(PadBothByLength("No. of occurances", PAD2)); Console.WriteLine("|");
        for(int i = 0; i < letterOccurances.Length; i++)
        {
            if(letterOccurances[i] > 0)
            {
                Console.Write("|"); Console.Write(PadBothByLength($"{(char)i}", PAD)); Console.Write("|"); Console.Write($"{letterOccurances[i]} ".PadLeft(PAD2)); Console.WriteLine("|");
            }
        }

        Console.WriteLine();

    }


    static string PadBothByAmount(string s, int amount=1)
    {
        // Method to pad string by equal amount on both left and right

        int totalLength = s.Length + (2 * amount);
        int lengthForLeftPadding = s.Length + amount;

        return s.PadLeft(lengthForLeftPadding).PadRight(totalLength);
    }


    static string PadBothByLength(string s, int length)
    {
        // Method to pad string by equal amount on both left and right
        // when total length of resultant string is given
        // length should be greater than initial length of string

        int initialStringLen = s.Length;
        if(length < initialStringLen)
        {
            length = initialStringLen + 2;
        }

        int totalPad = length - initialStringLen;
        int lengthWithLeftPadOnly = initialStringLen + (totalPad / 2);

        return s.PadLeft(lengthWithLeftPadOnly).PadRight(length);
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


    static int[] GetAllLettersIn(string s)
    {
        // Method to find all unique letters in given string along with 
        // how many times they are found and return them as array

        // array index = unicode value of character
        // value = no. of times that character occur
        int len = ushort.MaxValue + 1;
        int[] letterOccurances = new int[len];

        foreach(ushort c in s)
        {
            if(c >= 0 && c < len)
            {
                letterOccurances[c] += 1;
            }
        }

        return letterOccurances;
    }
}