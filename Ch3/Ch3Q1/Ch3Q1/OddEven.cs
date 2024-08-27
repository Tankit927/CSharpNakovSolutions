// Write an expression that checks whether an integer is odd or even.

class OddEven
{
    static void Main()
    {
        int num = 3;

        Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
    }
}