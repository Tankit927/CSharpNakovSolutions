// Write an if-statement that takes two integer variables and exchanges 
// their values if the first one is greater than the second one.

class ExchangeValues
{
    static void Main()
    {
        int num1, num2;
        bool isInt;

        Console.WriteLine("Program to take two integer variables and exchange " +
        "their values if the first one is greater than the second one.");
        Console.Write("Enter first num = ");
        isInt = int.TryParse(Console.ReadLine(), out num1);
        Console.WriteLine(isInt ? "" : "Invalid num");
        Console.Write("Enter second num = ");
        isInt = int.TryParse(Console.ReadLine(), out num2);
        Console.WriteLine(isInt ? "" : "Invalid num");

        Console.WriteLine("Original");
        Console.WriteLine($"num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");
        if(num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Exchangd");
            Console.WriteLine($"num1 = {num1}");
            Console.WriteLine($"num2 = {num2}");
        }
        else
        {
            Console.WriteLine("Same as original");
        }
    }
}