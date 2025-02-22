// Write a program that solves the following tasks: 
// - Put the digits from an integer number into a reversed order. 
// - Calculate the average of given sequence of numbers. 
// - Solve the linear equation a * x + b = 0.
// 
// Create appropriate methods for each of the above tasks. 
// Make the program show a text menu to the user. By choosing an option 
// of that menu, the user will be able to choose which task to be invoked.   
// Perform validation of the input data: 
// - The integer number must be a positive in the range [1…50,000,000]. 
// - The sequence of numbers cannot be empty. 
// - The coefficient a must be non-zero.

class Tasks
{
    static void Main()
    {
        int choice;

        Console.WriteLine("Choose from the following options:");
        Console.WriteLine("1. Put the digits from an integer number into a reversed order.");
        Console.WriteLine("2. Calculate the average of given sequence of numbers.");
        Console.WriteLine("3. Solve the linear equation a * x + b = 0.");
        choice = GetInt("", 1, 3);
        Console.WriteLine();
        switch(choice)
        {
            case 1:
                {
                    int num = GetInt("Num = ");
                    PrintInReverse(num);
                    break;
                }
            case 2:
                {
                    int len = GetInt("Amount of nos. you'll enter = ", 1);
                    int[] myArray = new int[len];
                    InitArray(myArray);

                    Console.WriteLine();
                    PrintArray(myArray);
                    Console.WriteLine($"Average = {GetAverage(myArray):f2}");
                    break;
                }
            case 3:
                {
                    int a = GetInt("a = ", x : 0);
                    int b = GetInt("b = ");
                    Console.WriteLine($"Value of x = {(-b / (double)a):f2}");
                    break;
                }
            default:
                {
                    Console.WriteLine("Error!");
                    break;
                }
        }
    }


    static int GetInt(string prompt, int? min = null, int? max = null, int? x = null)
    {
        // Method to user input integer
        // min <= integer <= max

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || (max != null && num > max) || (x != null && num == x))
            {
                Console.WriteLine($"\nEnter a valid integer range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
                if(x != null)
                {
                    Console.WriteLine($"Integer should not be {x}");
                }
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max) || (x != null && num == x));

        return num;
    }


    static void PrintInReverse(int n)
    {
        // Method to print given integer in reverse

        Console.Write(n < 0 ? "-" : "");
        n = Math.Abs(n);
        do
        {
            Console.Write(n % 10);
            n /= 10;
        }
        while(n != 0);

        Console.WriteLine();
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise the given array

        int min  = 1;
        int max = 50_000_000;

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"Num{i} = ", min, max);
        }
    }


    static double GetAverage(params int[] myArray)
    {
        // Method to return average of given integers

        double average = 0.0;
        int len = myArray.Length;

        foreach(int i in myArray)
        {
            average += i;
        }

        average /= len;

        return average;
    }


    static void PrintArray(int[] myArray)
    {
        // Method to print given array

        int len = myArray.Length;

        Console.Write("{");
        for(int i = 0; i < len; i++)
        {
            if(i < len-1)
            {
                Console.Write($"{myArray[i]}, ");
            }
            else
            {
                Console.Write($"{myArray[i]}");
            }
        }

        Console.WriteLine("}");
    }
}