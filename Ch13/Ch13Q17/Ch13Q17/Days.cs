// Write a program that reads two dates entered in the format 
// "day.month.year" and calculates the number of days between them. 
// Enter the first date: 27.02.2006 
// Enter the second date: 3.03.2006 
// Distance: 4 days

class Days
{
    static void Main()
    {
        Console.WriteLine("Program to calculate the number of days between two given dates");
        DateTime d1 = GetDateTime("Enter the first date: ");
        DateTime d2 = GetDateTime("Enter the second date: ");
        Console.WriteLine($"Days: {CalculateDaysBetween(d1, d2)}");
    }


    static DateTime GetDateTime(string prompt)
    {
        // Method to user input DateTime

        DateTime dt;
        bool isDateTime;

        do
        {
            Console.Write(prompt);
            isDateTime = DateTime.TryParse(Console.ReadLine(), out dt);
            if(!isDateTime)
            {
                Console.WriteLine($"\nEnter a valid Date");
            }
        }
        while(!isDateTime);

        return dt;
    }


    static int CalculateDaysBetween(DateTime d1, DateTime d2)
    {
        // Method to calculate no. of days between two given dates

        if(d1.CompareTo(d2) < 0)
        {
            return d2.Subtract(d1).Days;
        }
        
        return d1.Subtract(d2).Days;
        
    }
}