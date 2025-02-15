// Write a program that by a given integer N prints the numbers from 1 to N 
// in random order.

// Need to complete Ch-7 Arrays

class PrintNumsInRandomOrder
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to print nums 1-N in random order.");

        // User input
        do
        {
            Console.Write("N = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 2)
            {
                Console.WriteLine($"\nEnter a valid integer in range[2,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 2);

        // Init array
        int[] myArray = new int[n];
        for(int i = 0; i < n; i++)
        {
            myArray[i] = i + 1;
        }

        // Logic to randomise the order of elements in the array
        Console.WriteLine();
        Console.WriteLine("Given array:");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }

        Random rg = new Random();
        for(int count = 1, i = rg.Next(n), j = rg.Next(n), temp; count <= n; count++, i = rg.Next(n), j = rg.Next(n))
        {
            temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;
        }

        Console.WriteLine();
        Console.WriteLine("Randomised array:");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
    }
}