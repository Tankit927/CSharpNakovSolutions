// Write a program that reads a string, reverse it and prints it to the 
// console. For example: "introduction" --> "noitcudortni".

using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Program to reverse given string");
        string s = GetString("Enter something: ");

        Console.WriteLine();
        Console.WriteLine(Reverse(s));
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


    static string Reverse(string s)
    {
        // Method to reverse given string

        int len = s.Length;
        StringBuilder sb = new(len);

        for(int i = len-1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}