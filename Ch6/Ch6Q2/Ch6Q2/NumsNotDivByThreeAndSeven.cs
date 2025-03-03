// Write a program that prints on the console the numbers from 1 to N, 
// which are not divisible by 3 and 7 simultaneously. The number N 
// should be read from the standard input.

class NumsNotDivByThreeAndSeven
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to print numbers 1 to n which are " +
        "not divisible by 3 and 7 simultaneously");
        do
        {
            Console.Write("Enter n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt)
            {
                Console.WriteLine("Invalid number!");
            }
        }
        while(!isInt);

        for(int i = 1; i <= n; i++)
        {
            if((i % 3 != 0) || (i % 7 != 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}
