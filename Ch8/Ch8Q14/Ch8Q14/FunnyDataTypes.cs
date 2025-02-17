// Try adding up 50,000,000 times the number 0.000001. Use a loop 
// and addition (not direct multiplication). Try it with float and double and 
// after that with decimal. Do you notice the huge difference in the 
// results and speed of calculation? Explain what happens.

class FunnyDataTypes
{
    static void Main()
    {
        float n = 0.000001f, sumf = 0.0f;
        double m = 0.000001d, sumd = 0.0d;
        decimal o = 0.000001m, summ = 0.0m;

        Console.WriteLine("Adding 50,000,000 times the number 0.000001 as " +
        "float, double and decimal.");

        Console.WriteLine("Float:");
        Console.Write("Adding 50,000,000 times 0.000001f = ");
        for(int i = 1; i <= 50_000_000; i++)
        {
            sumf += n;
        }
        Console.WriteLine(sumf);

        Console.WriteLine("Double:");
        Console.Write("Adding 50,000,000 times 0.000001d = ");
        for(int i = 1; i <= 50_000_000; i++)
        {
            sumd += m;
        }
        Console.WriteLine(sumd);

        Console.WriteLine("Decimal:");
        Console.Write("Adding 50,000,000 times 0.000001m = ");
        for(int i = 1; i <= 50_000_000; i++)
        {
            summ += o;
        }
        Console.WriteLine(summ);
    }
}