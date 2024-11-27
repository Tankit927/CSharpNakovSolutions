// Write an expression that checks whether the third bit in a given integer 
// is 1 or 0.

class CheckThirdBit
{
    static void Main()
    {
        int num = 11;

        Console.WriteLine((num & 4) == 4 ? "Third bit is 1" : "Third bit is 0");
    }
}