// Write a method that returns the position of the first occurrence of an 
// element from an array, such that it is greater than its two neighbors 
// simultaneously. Otherwise the result must be -1.

class GreaterThanNeighbours
{
    static void Main()
    {
        int len;

        Console.WriteLine("Program to find the first element in the given array " +
        "which is greater than its neighbours.");
        len = GetInt("Length of array = ");
        int[] myArray = new int[len];

        Console.WriteLine();
        InitArray(myArray);

        Console.WriteLine();
        PrintArray(myArray);
        int index = GetIndexOfElementGreaterThanNeighbours(myArray);
        if(index >= 0)
        {
            Console.WriteLine($"First element greater than its neighbours = {myArray[index]} at index {index}");
        }
        else
        {
            Console.WriteLine($"There is no element greater than its neigbours");
        }
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
        // Method to initialise the elements of given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"myArray[{i}] = ");
        }
    }


    static bool IsGreaterThanNeighbours(int index, params int[] myArray)
    {
        // Method to check whether element at given index in given array
        // is greater than its neighbours or not

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


    static int GetIndexOfElementGreaterThanNeighbours(params int[] myArray)
    {
        // Method to return index of first element which is greater than its
        // neighbours in the given array

        for(int i = 0; i < myArray.Length; i++)
        {
            if(IsGreaterThanNeighbours(i, myArray))
            {
                return i;
            }
        }

        return -1;
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
}