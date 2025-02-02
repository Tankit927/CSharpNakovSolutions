// Write a program that reads from the console a series of integers and 
// prints the smallest and largest of them.

class PrintSmallestNLargest
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to read n integers and print smallest and " +
        "largest of them.");
        do
        {
            Console.Write("Enter n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n <= 0)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,{int.MaxValue}]");
            }
        }
        while(!isInt || n <= 0);

        int min, max, num;
        Console.WriteLine();
        do
        {
            Console.Write($"Enter num1 = ");
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt)
            {
                Console.WriteLine($"\nEnter a valid integer in range [{int.MinValue},{int.MaxValue}]");
            }
        }
        while(!isInt);
        min = max = num;
        for(int i = 2; i <= n; i++)
        {
            do
            {
                Console.Write($"Enter num{i} = ");
                isInt = int.TryParse(Console.ReadLine(), out num);
                if(!isInt)
                {
                    Console.WriteLine($"\nEnter a valid integer in range [{int.MinValue},{int.MaxValue}]");
                }
            }
            while(!isInt);

            if(num < min)
            {
                min = num;
            }

            if(num > max)
            {
                max = num;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Smallest num = {min}");
        Console.WriteLine($"Largest num = {max}");
    }
}