// Write an expression that looks for a given integer if its third digit (right 
// to left) is 7.

class IsThirdDigitSeven
{
    static void Main()
    {
        int num, temp;
        num = temp = 123456777;
        int quotient;

        quotient = temp / 100;
        int hundredthDigit = Math.Abs(quotient % 10);

        Console.WriteLine($"Hundredth Digit of {num} = {hundredthDigit}");
        Console.WriteLine($"Is third digit 7: {hundredthDigit == 7}");
    }
}