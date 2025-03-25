// Write a program, which generates and prints on the console 10 random 
// numbers in the range [100, 200].

class RandomNums
{
    static void Main()
    {
        int min, max;

        Console.WriteLine("Program to print 10 random numbers in a given range");
        min = GetInt("min: ");
        max = GetInt("max: ", max:int.MaxValue-1);
        Console.WriteLine();
        PrintRandomNumsInRange(min, max);
    }


    static int GetInt(string prompt, int? min=null, int? max=null)
    {
        // Method to user input integer
        // min <= integer <= max

        int num; 
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static void PrintRandomNumsInRange(int min, int max)
    {
        // Method to print 10 random numbers in given range inclusively

        if(min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }

        Random rng = new Random();

        for(int i = 1; i <= 10; i++)
        {
            Console.Write($"{rng.Next(min, max+1)} ");
        }
    }
}