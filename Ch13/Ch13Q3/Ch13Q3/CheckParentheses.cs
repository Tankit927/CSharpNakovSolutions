// Write a program that checks whether the parentheses are placed 
// correctly in an arithmetic expression. Example of expression with 
// correctly placed brackets: ((a+b)/5-d). Example of an incorrect 
// expression: )(a+b)).

class CheckParentheses
{
    static void Main()
    {
        Console.WriteLine("Program to check whether given expression has correctly " +
        "placed brackeks or not");
        string s = GetString("Enter expression: ");

        Console.WriteLine(IsCorrectParentheses(s) ? "Expression is correct" : "Expression is wrong");
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


    static bool IsCorrectParentheses(string s)
    {
        // Method to check whether parentheses are correctly placed
        // in given expression or not
        //
        // Parentheses are correct when
        // 1. No. of '(' is equal to ')'
        // and
        // 2. Last index of ')' is greater than last index of '('

        int openBraceCount, closeBraceCount;
        openBraceCount = closeBraceCount = 0;

        foreach(char c in s)
        {
            if(c == '(')
            {
                openBraceCount++;
            }
            else if(c == ')')
            {
                closeBraceCount++;
            }
        }

        if(openBraceCount != closeBraceCount)
        {
            return false;
        }

        if(s.LastIndexOf('(') > s.LastIndexOf(')'))
        {
            return false;
        }

        return true;
    }
}