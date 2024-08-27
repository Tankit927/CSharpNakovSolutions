// Write a Boolean expression that checks if the bit on position p in the 
// integer v has the value 1. Example v=5, p=1 -> false.

class CheckBit
{
    static void Main()
    {
        long num;
        int p;

        Console.WriteLine("Program to check whether the bit in position p " +
        "in given integer is 1");
        Console.Write("Enter num: ");
        num = long.Parse(Console.ReadLine());
        Console.Write("Enter p: ");
        p = int.Parse(Console.ReadLine());
        
        long i = 1;
        long mask = i << p;
        Console.WriteLine((num & mask) != 0);
    }
}