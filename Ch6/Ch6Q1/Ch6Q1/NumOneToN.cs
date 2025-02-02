// Write a program that prints on the console the numbers from 1 to N. 
// The number N should be read from the standard input. 

class NumOneToN
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to print numbers 1 to n");
        do
        {
            Console.Write("Enter n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt)
            {
                Console.WriteLine("Invalid number!");
            }
        } while (!isInt);

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}