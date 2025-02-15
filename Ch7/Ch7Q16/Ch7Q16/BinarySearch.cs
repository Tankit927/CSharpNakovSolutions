// Write a program, which uses a binary search in a sorted array of 
// integer numbers to find a certain element.

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Program that uses binary search in given sorted array " +
        "of integer numbers to find a certain given element");

        // int[] myArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] myArray = {0, 1, 2, 3, 4};

        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // User input
        int num;
        bool isInt;

        do
        {
            Console.Write("Enter num: ");
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt)
            {
                Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
            }
        }
        while(!isInt);

        // Binary search logic
        int low = 0, high = myArray.Length - 1;
        int mid = low + ((high - low) / 2);
        bool isFound = false;

        while(low <= high)
        {
            mid = low + ((high - low) / 2);
            if(num == myArray[mid])
            {
                isFound = true;
                break;
            }
            else if(num < myArray[mid])
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        if(isFound)
        {
            Console.WriteLine($"Index = {mid}");
        }
        else
        {
            Console.WriteLine("Index not found");
        }
    }
}