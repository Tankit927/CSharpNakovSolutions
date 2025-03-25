// Write a program, which prints, on the console which day of the week is 
// today.

class Day
{
    static void Main()
    {
        DateTime dt = DateTime.Today;
        Console.WriteLine($"Today is {dt.DayOfWeek} {dt.Day}/{dt.Month}/{dt.Year}");
    }
}