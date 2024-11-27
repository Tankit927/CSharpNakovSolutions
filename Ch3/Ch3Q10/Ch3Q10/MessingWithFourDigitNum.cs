// Write a program that takes as input a four-digit number in format abcd
// (e.g. 2011) and performs the following actions:
// - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
// - Prints on the console the number in reversed order: dcba (in our 
// example 1102).
// - Puts the last digit in the first position: dabc (in our example 1201).
// - Exchanges the second and the third digits: acbd (in our example 
// 2101).

class MessingWithFourDigitNum
{
    static void Main()
    {
        int num;

        Console.Write("Enter a four digit num: ");
        num = int.Parse(Console.ReadLine());

        int a = num / 1000;
        int b = (num / 100) % 10;
        int c = (num / 10) % 10;
        int d = num % 10;

        Console.WriteLine($"Sum of digit = {a + b + c + d}");
        Console.WriteLine("Reversed = " + d + c + b + a);
        Console.WriteLine("Last digit in first position = " + d + a + b + c);
        Console.WriteLine("Second and third digits exchanged = " + a + c + b + d);
    }
}