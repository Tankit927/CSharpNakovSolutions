// Write a program that detects how many times a substring is contained in 
// the text. For example, let's look for the substring "in" in the text: 
// We are living in a yellow submarine. We don't have anything 
// else. Inside the submarine is very tight. So we are drinking 
// all the day. We will move out of it in 5 days. 
// The result is 9 occurrences.


class OccurancesOfSubstring
{
    static void Main()
    {
        Console.WriteLine("Program to find no. of occurances of substring in a given string");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        string sub = GetString("Enter substring: ");

        Console.WriteLine();
        Console.WriteLine($"No. of occurances: {FindNumberOfOccurances(s, sub)}");
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


    static int FindNumberOfOccurances(string s, string sub)
    {
        // Method to find the no. of occurances of substring sub in string s

        int len = s.Length;
        int count = 0;
        int index = 0;

        while(index > -1 && index < len)
        {
            index = s.IndexOf(sub, index, StringComparison.InvariantCultureIgnoreCase);
            if(index > -1)
            {
                count++;
                index++;
            }
        }

        return count;
    }
}