// Write a program that reads from the console two integer numbers (int) 
// and prints how many numbers between them exist, such that the 
// remainder of their division by 5 is 0. Example: in the range (14, 25) 
// there are 3 such numbers: 15, 20 and 25.

class DivisibleByFive
{
    static void Main()
    {
        int a, b;
        bool isInt;

        Console.WriteLine("Program to print nos. divisible by five in " +
        "given range exclusively.");
        Console.Write("Enter first no.: ");
        isInt = int.TryParse(Console.ReadLine(), out a);
        Console.Write("Enter second no.: ");
        isInt = int.TryParse(Console.ReadLine(), out b);

        int temp = a;
        a = (a < b ? a : b);
        b = (b > temp ? b : temp);

        Console.WriteLine();
        for(int i = a; i <= b; i++)
        {
            if(i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}