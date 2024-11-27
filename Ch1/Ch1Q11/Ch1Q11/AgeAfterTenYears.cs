// Write a program that reads your age from the console and prints your 
// age after 10 years.

class AgeAfterTenYears
{
    static void Main()
    {
        int num;

        Console.Write("Enter age: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Age after 10 years = {num + 10}");
    }
}