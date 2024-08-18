// Write a program, which compares correctly two real numbers with 
// accuracy at least 0.000001.

class ComparingRealNums
{
    static void Main()
    {
        float num1 = 1.234567f;
        float num2 = 1.234567f;
        float num3 = 1.234566f;

        Console.WriteLine($"Is {num1} == {num2}: {num1 == num2}");
        Console.WriteLine($"Is {num1} == {num3}: {num1 == num3}");
    }
}