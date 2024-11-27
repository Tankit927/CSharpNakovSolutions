// Sort 3 real numbers in descending order. Use nested if statements.

class Sort
{
    static void Main()
    {
        double n1, n2, n3;
        bool isDouble;

        Console.WriteLine("Program to sort 3 real numbers in descending order.");
        Console.Write("Enter first number = ");
        isDouble = double.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Enter second number = ");
        isDouble = double.TryParse(Console.ReadLine(), out n2);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Enter third number = ");
        isDouble = double.TryParse(Console.ReadLine(), out n3);
        Console.WriteLine(isDouble ? "" : "Invalid number");

        Console.Write("Descending order = ");
        if(n1 >= n2 && n1 >= n3)
        {
            if(n2 >= n3)
            {
                Console.WriteLine($"{n1}, {n2}, {n3}");
            }
            else
            {
                Console.WriteLine($"{n1}, {n3}, {n2}");
            }
        }
        else if(n2 >= n1 && n2 >= n3)
        {
            if(n1 >= n3)
            {
                Console.WriteLine($"{n2}, {n1}, {n3}");
            }
            else
            {
                Console.WriteLine($"{n2}, {n3}, {n1}");
            }
        }
        else
        {
            if(n1 >= n2)
            {
                Console.WriteLine($"{n3}, {n1}, {n2}");
            }
            else
            {
                Console.WriteLine($"{n3}, {n2}, {n1}");
            }
        }
    }
}