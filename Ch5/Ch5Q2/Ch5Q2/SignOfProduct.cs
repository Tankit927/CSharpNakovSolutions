// Write a program that shows the sign (+ or -) of the product of three real 
// numbers, without calculating it. Use a sequence of if operators.

class SignOfProduct
{
    static void Main()
    {
        double n1, n2, n3;
        bool isDouble;

        Console.WriteLine("Program to show sign of the product of three " +
        "given numbers without calculating it.");
        Console.Write("Enter first number = ");
        isDouble = double.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Enter second number = ");
        isDouble = double.TryParse(Console.ReadLine(), out n2);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Enter thrid number = ");
        isDouble = double.TryParse(Console.ReadLine(), out n3);
        Console.WriteLine(isDouble ? "" : "Invalid number");

        Console.Write("Sign of product = ");
        if((n1 < 0 && n2 < 0 && n3 < 0) || (n1 < 0 && n2 > 0 && n3 > 0) || (n1 > 0 && n2 < 0 && n3 > 0) || (n1 > 0 && n2 > 0 && n3 < 0))
        {
            Console.WriteLine("-");
        }
        else if((n1 < 0 && n2 < 0 && n3 > 0) || (n1 < 0 && n2 > 0 && n3 < 0) || (n1 > 0 && n2 < 0 && n3 < 0) || (n1 < 0 && n2 > 0 && n3 < 0) || (n1 > 0 && n2 > 0 && n3 > 0) || (n1 == 0 || n2 == 0 || n3 == 0))
        {
            Console.WriteLine("+");
        }
    }
}