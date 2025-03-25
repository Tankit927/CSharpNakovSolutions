// Write a program, which reads from the console a year and checks if it is 
// a leap year.

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Program to find whether given year is a leap year or not");
        int year = GetInt("Year: ", 1, 9999);
        Console.WriteLine($"\n{year} is leap year: {IsLeapYear(year)}");
        Console.WriteLine();
        Console.WriteLine("Checking using DateTime.IsLeapYear()");
        Console.WriteLine($"{year} is leap year: {DateTime.IsLeapYear(year)}");
    }


    static int GetInt(string prompt, int? min=null, int? max=null)
    {
        // Method to user input integer
        // min <= integer <= max

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static bool IsLeapYear(int year)
    {
        // Method to check whether given year is leap year or not

        if((year % 100 != 0 && year % 4 == 0) || year % 400 == 0)
        {
            return true;
        }

        return false;
    }
}