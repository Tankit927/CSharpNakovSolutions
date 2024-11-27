// We are given a number n and a position p. Write a sequence of 
// operations that prints the value of the bit on the position p in the 
// number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
// p=6 -> 0.

class BitInPositionP
{
    static void Main()
    {
        long num;
        int p;

        Console.WriteLine("Program to print the value of the bit on the " +
        "position p in the given number.");
        Console.Write("Enter a num: ");
        num = long.Parse(Console.ReadLine());
        Console.Write("p: ");
        p = int.Parse(Console.ReadLine());

        long powerOfTwo = (long)Math.Pow(2, p);
        Console.WriteLine((num & powerOfTwo) == powerOfTwo ? 1 : 0);
    }
}