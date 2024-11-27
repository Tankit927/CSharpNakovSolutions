// Write a Boolean expression that checks whether a given integer is 
// divisible by both 5 and 7, without a remainder.

class DivisibleByFiveNSeven
{
    static void Main()
    {
        int num = 42;

        Console.WriteLine(num % 5 == 0 && num % 7 == 0 ? $"{num} is divisible by 5 and 7" : $"{num} is not divisible by 5 and 7");
    }
}