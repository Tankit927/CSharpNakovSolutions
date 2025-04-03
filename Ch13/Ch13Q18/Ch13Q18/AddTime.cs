// Write a program that reads the date and time entered in the format 
// "day.month.year hour:minutes:seconds" and prints the date and time 
// after 6 hours and 30 minutes in the same format.


class AddTime
{
    static void Main()
    {
        Console.WriteLine("Program to add time to given date time");
        DateTime dateTime = GetDateTime("Enter date time in format day.month.year hour:minutes:seconds\n");

        Console.WriteLine();
        TimeSpan timeSpan = GetTimeSpan("Enter time in format day.hour:minutes:seconds\n");

        Console.WriteLine();
        Console.WriteLine($"New Time:");
        Console.WriteLine($"{AddTimeTo(dateTime, timeSpan):dd.MM.yyyy hh:mm:ss}");
    }


    static TimeSpan GetTimeSpan(string prompt)
    {
        // Method to user input TimeSpan

        TimeSpan t;
        bool isTimeSpan;

        do
        {
            Console.Write(prompt);
            isTimeSpan = TimeSpan.TryParse(Console.ReadLine(), out t);
            if(!isTimeSpan)
            {
                Console.WriteLine("\nEnter a valid TimeSpan");
            }
        }
        while(!isTimeSpan);

        return t;
    }


    static DateTime GetDateTime(string prompt)
    {
        // Method to user input DateTime object

        DateTime d;
        bool isDateTime;

        do
        {
            Console.Write(prompt);
            isDateTime = DateTime.TryParse(Console.ReadLine(), out d);
            if(!isDateTime)
            {
                Console.WriteLine("\nEnter a valid DateTime");
            }
        }
        while(!isDateTime);

        return d;
    }


    static DateTime AddTimeTo(DateTime dateTime, TimeSpan timeSpan)
    {
        // Method to add timeSpan to given dateTime

        return dateTime.Add(timeSpan);
    }
}