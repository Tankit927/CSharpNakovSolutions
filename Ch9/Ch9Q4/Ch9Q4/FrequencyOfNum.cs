// Write a method that finds how many times certain number can be 
// found in a given array. Write a program to test that the method works 
// correctly.

class FrequencyOfNum
{
    static void Main()
    {
        int n, len, frequency;

        Console.WriteLine("Program to find how many times certain given number " +
        "can be found in a given array.");

        len = GetInt("Length of array = ", 0);
        int[] myArray = new int[len];

        Console.WriteLine("Enter elements in the given array");
        InitArray(myArray);

        Console.WriteLine();
        n = GetInt("Num = ");
        frequency = GetFrequencyOf(n, myArray);

        Console.WriteLine();
        PrintArray(myArray);
        Console.WriteLine($"{n} occurs {frequency} times");
    }


    static int GetInt(string prompt, int? min = null)
    {
        // Method to user input integer where integer > min

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num <= min))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min != null ? min+1 : int.MinValue)},{int.MaxValue}]");
            }
        }
        while(!isInt || (min != null && num <= min));

        return num;
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"myArray[{i}] = ");
        }
    }


    static void PrintArray(int[] myArray)
    {
        // Method to print array

        int len = myArray.Length;

        Console.Write("{");
        for(int i = 0; i < len; i++)
        {
            if(i < len - 1)
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


    static int GetFrequencyOf(int num, params int[] myArray)
    {
        // Method to find frequency of given num in given array

        int count = 0;

        foreach(int i in myArray)
        {
            if(i == num)
            {
                count += 1;
            }
        }

        return count;
    }
}