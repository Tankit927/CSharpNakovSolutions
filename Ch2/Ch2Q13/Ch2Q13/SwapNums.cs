// Declare two variables of type int. Assign to them values 5 and 10 
// respectively. Exchange (swap) their values and print them.

class SwapNums
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before swap\n" +
        $"a = {a}\n" +
        $"b = {b}\n");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swap\n" +
        $"a = {a}\n" +
        $"b = {b}");
    }
}