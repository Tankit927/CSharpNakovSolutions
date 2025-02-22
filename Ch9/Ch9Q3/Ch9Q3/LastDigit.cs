// Write a method that returns the English name of the last digit of a 
// given number. Example: for 512 prints "two"; for 1024 -> "four".

class LastDigit
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to name the last digit of the given integer.");
        n = GetInt("Num = ");
        Console.WriteLine($"Last digit = {NameLastDigit(n)}");
    }


    static int GetInt(string prompt)
    {
        // Method to user input integer

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt)
            {
                Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
            }
        }
        while(!isInt);

        return num;
    }


    static string NameLastDigit(int n)
    {
        // Method to name the last digit of the given integer

        int lastDigit =  Math.Abs(n % 10);

        switch(lastDigit)
        {
            case 0: return "Zero";
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            default: return "Error";
        }
    }
}