// Write a method that checks whether an element, from a certain position 
// in an array is greater than its two neighbors. Test whether the 
// method works correctly.

class GreaterThanNeighbours
{
    static void Main()
    {
        int len, index;

        Console.WriteLine("Program to find whether element at given position " +
        "is greater than its two neighbours.");

        len = GetInt("Length of array = ", 1);
        int[] myArray = new int[len];
        Console.WriteLine("Enter elements in the given array");
        InitArray(myArray);

        Console.WriteLine();
        index = GetInt("Index = ", 0, len-1);

        Console.WriteLine();
        PrintArray(myArray);
        Console.WriteLine($"Is myArray[{index}] {myArray[index]} greater than "
        + $"its neighbours = {IsGreaterThanNeighbours(index, myArray)}");
    }


    static int GetInt(string prompt, int? min = null, int? max = null)
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


    static void InitArray(int[] myArray)
    {
        // Method to initialise given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"myArray[{i}] = ");
        }
    }


    static bool IsGreaterThanNeighbours(int index, params int[] myArray)
    {
        // Method to find whether element at given index is greater than its
        // neighbours or not

        int len = myArray.Length;

        if(index < 0 || index >= len)
        {
            return false;
        }
        else if(index-1 >= 0 && index-1 < len && index+1 >= 0 && index+1 < len)
        {
            if(myArray[index] > myArray[index-1] && myArray[index] > myArray[index+1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if(index-1 >= 0 && index-1 < len && (index+1 < 0 || index+1 >= len))
        {
            if(myArray[index] > myArray[index-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if(index+1 >= 0 && index+1 < len && (index-1 < 0 || index-1 >= len))
        {
            if(myArray[index] > myArray[index+1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }


    static void PrintArray(params int[] myArray)
    {
        // Method to print int array

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