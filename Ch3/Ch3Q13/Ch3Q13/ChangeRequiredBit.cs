// We are given the number n, the value v (v = 0 or 1) and the position p. 
// write a sequence of operations that changes the value of n, so the bit on 
// the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
// Another example: n=35, p=2, v=1 -> n=39.

class ChangeRequiredBit
{
    static void Main()
    {
        long num;
        int v, p;

        Console.WriteLine("Program to change the p-th bit of given num by v");
        Console.Write("Enter num: ");
        num = long.Parse(Console.ReadLine());
        Console.Write("p: ");
        p = int.Parse(Console.ReadLine());
        Console.Write("v (0 or 1): ");
        v = int.Parse(Console.ReadLine());

        num = num & (~(1L << p));
        Console.WriteLine(v == 1 ? num | (1L << p) : num);
    }
}