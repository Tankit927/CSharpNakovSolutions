// Write a program, which calculates the count of workdays between 
// the current date and another given date after the current (inclusive). 
// Consider that workdays are all days from Monday to Friday, which are not 
// public holidays, except when Saturday is a working day. The program 
// should keep a list of predefined public holidays, as well as a list of 
// predefined working Saturdays.

class Workdays
{
    static void Main()
    {
        Console.WriteLine("Program to calculate no. of workdays between today " +
        "and given date");
        DateTime date = GetDate("Enter date: ");
        Console.WriteLine();

        Console.WriteLine($"Work days between {DateTime.Today.ToShortDateString()} and {date.ToShortDateString()}: {CountWorkdays(date)}");
    }


    static DateTime GetDate(string prompt)
    {
        // Method to user input date

        DateTime date;
        bool isDateTime;

        do
        {
            Console.Write(prompt);
            isDateTime = DateTime.TryParse(Console.ReadLine(), out date);
            if(!isDateTime)
            {
                Console.WriteLine("\nEnter a valid date");
            }
        }
        while(!isDateTime);

        return date;
    }


    static int CountWorkdays(DateTime givenDate)
    {
        // Method to calculate no. of working days between today
        // and given date

        DateTime min, max, today;
        today = DateTime.Now;
        min = today;
        max = givenDate;
        int workdays = 0;

        if(givenDate.CompareTo(today) == -1)
        {
            min = givenDate;
            max = today;
        }

        for(DateTime i = min; i.CompareTo(max) <= 0; i = i.AddDays(1))
        {
            if(i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday)
            {
                workdays++;
            }
        }

        return workdays;
    }
}