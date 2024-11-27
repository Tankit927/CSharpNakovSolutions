// Write a program that, depending on the user’s choice, inputs int, double 
// or string variable. If the variable is int or double, the program 
// increases it by 1. If the variable is a string, the program appends "*" at 
// the end. Print the result at the console. Use switch statement.

class UserChoice
{
    static void Main()
    {
        int n1;
        double n2;
        string myString;
        byte choice;
        bool isByte;
        bool isInt;
        bool isDouble;

        Console.WriteLine("Program that increases the given variable by 1 " +
        "or appends \"*\" at the end depending on its type.");
        Console.WriteLine("Enter your choice:");
        Console.WriteLine("1. Integer");
        Console.WriteLine("2. Double (decimal number)");
        Console.WriteLine("3. String");
        isByte = byte.TryParse(Console.ReadLine(), out choice);
        Console.WriteLine(isByte ? "" : "Invalid number");

        switch(choice)
        {
            case 1:
            {
                Console.Write("Enter integer = ");
                isInt = int.TryParse(Console.ReadLine(), out n1);
                Console.WriteLine(isInt ? $"New integer = {n1 + 1}" : "Invalid number");
                break;
            }
            case 2:
            {
                Console.Write("Enter double (decimal number) = ");
                isDouble = double.TryParse(Console.ReadLine(), out n2);
                Console.WriteLine(isDouble ? $"New double = {n2 + 1}" : "Invalid number");
                break;
            }
            case 3:
            {
                Console.Write("Enter a string = ");
                myString = Console.ReadLine();
                Console.WriteLine("New string = " + myString + "*");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}