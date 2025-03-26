// You are given a sequence of positive integer numbers given as string 
// of numbers separated by a space. Write a program, which calculates 
// their sum. Example: "43 68 9 23 318" --> 461.

class Sum
{
    static void Main()
    {
        Console.WriteLine("Program to sum space separated integers");
        string nums = GetString("Enter nums separated by space: ");
        Console.WriteLine();

        Console.WriteLine($"Sum = {GetSum(nums)}");
    }


    static string GetString(string prompt)
    {
        string s;

        do
        {
            Console.Write(prompt);
            s = Console.ReadLine();
            if(string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("\nEnter something bruh!");
            }
        }
        while(string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s));

        return s;
    }


    static long GetSum(string nums)
    {
        // Method to sum space separated integers

        long sum = 0;
        string[] array = nums.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for(int i = 0; i < array.Length; i++)
        {
            try
            {
                sum += int.Parse(array[i]);
            }
            catch(Exception){}
        }

        return sum;
    }
}