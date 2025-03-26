// Write a program, which prints on the standard output the count of days, 
// hours, and minutes, which have passes since the computer is 
// started until the moment of the program execution. For the 
// implementation use the class Environment.

class TimePassed
{
    static void Main()
    {
        Console.WriteLine("Time passed since system started:");
        PrintPassedTime();
    }


    static void PrintPassedTime()
    {
        // Method to print passed time since system started

        long ticks = Environment.TickCount64;
        long[] time = TicksToDaysHoursMinuteSeconds(ticks);

        if(time[0] > 0)
        {
            Console.Write($"{time[0]} days ");
        }

        if(time[1] > 0)
        {
            Console.Write($"{time[1]} hours ");
        }

        if(time[2] > 0)
        {
            Console.Write($"{time[2]} minutes ");
        }

        if(time[3] > 0)
        {
            Console.Write($"{time[3]} seconds ");
        }

        if(time[4] > 0)
        {
            Console.Write($"{time[4]} ticks");
        }

        Console.WriteLine();
    }


    static long[] TicksToDaysHoursMinuteSeconds(long ticks)
    {
        // Method to convert ticks to days, hours, minutes and seconds

        long days, hours, minutes, seconds;
        days = hours = minutes = seconds = 0;

        if(ticks >= 24*60*60*1000)
        {
            days = ticks / (24*60*60*1000);
            ticks %= (24*60*60*1000);
        }

        if(ticks >= 60*60*1000)
        {
            hours = ticks / (60*60*1000);
            ticks %= (60*60*1000);
        }

        if(ticks >= 60*1000)
        {
            minutes = ticks / (60*1000);
            ticks %= (60*1000);
        }

        if(ticks >= 1000)
        {
            seconds = ticks / 1000;
            ticks %= 1000;
        }

        return [days, hours, minutes, seconds, ticks];
    }
}