// Write a program that prints on the console the current date and time.

class CurrentDateNTime
{
    static void Main()
    {
        DateTime datetime = DateTime.Now;

        Console.WriteLine($"Current date = {datetime.Date}\n" +
        $"Current time = {datetime.TimeOfDay}");
    }
}