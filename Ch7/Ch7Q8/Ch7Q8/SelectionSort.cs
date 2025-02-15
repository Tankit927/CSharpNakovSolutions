// Sorting an array means to arrange its elements in an increasing (or 
// decreasing) order. Write a program, which sorts an array using the 
// algorithm "selection sort".

class SelectionSort
{
    static void Main()
    {
        int len;
        bool isInt;

        Console.WriteLine("Program to sort given array using Selection Sort " +
        "algorithm.");

        // User inputs
        do
        {
            Console.Write("Length of array = ");
            isInt = int.TryParse(Console.ReadLine(), out len);
            if(!isInt || len < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || len < 1);

        int[] myArray = new int[len];
        Console.WriteLine("Enter elements in the array");
        for(int i = 0; i < len; i++)
        {
            do
            {
                Console.Write($"myArray[{i}] = ");
                isInt = int.TryParse(Console.ReadLine(), out myArray[i]);
                if(!isInt)
                {
                    Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
                }
            }
            while(!isInt);
        }
        
        //// Testing
        //string nums = "61 91 4 20 60 21 22 49 18 61 62 88 19 35 94 30 46 82 2 49 40 4 54 18 13 45 18 99 91 95 79 53 77 83 18 55 84 72 79 27 93 75 36 24 13 46 59 59 88 16 6 15 16 17 62 32 81 32 36 43 93 9 41 23 14 11 8 24 44 50 32 81 82 79 75 12 35 94 6 13 81 53 40 1 2 5 92 78 34 5 36 95 70 69 19 4 92 77 66 39 7 98 45 62 25 88 46 53 46 57 29 59 62 85 6 91 67 57 25 43 59 5 84 49 36 94 61 3 71 3 85 10 35 4 76 83 36 17 21 4 82 72 31 43 44 77 79 15 14 60 68 84 14 6 86 85 7 46 87 92 93 10 14 91 56 33 85 9 22 45 83 88 93 89 43 24 58 20 80 84 72 43 50 50 55 66 68 7 45 29 30 41 84 25 55 91 74 77 38 37 81 13 36 11 14 49 11 3 45 14 57 1 44 61 24 32 62 11 46 84 35 99 54 44 100 71 73 78 52 64 72 11 36 55 28 17 60 46 88 99 43 32 62 59 18 53 80 15 66 92 98 71 14 55 7 100 7 76 30 21 20 11 41 22 41 90 51 65 14 81 58 76 40 74 63 35 6 81 18 1 37 79 99 49 91 17 54 71 50 32 51 72 20 81 55 70 41 89 70 39 12 87 35 39 92 46 43 56 54 4 16 18 29 87 36 37 5 19 85 49 80 91 46 70 53 96 74 18 28 44 27 90 1 69 83 62 42 69 56 95 58 37 84 100 56 79 5 81 40 53 67 82 58 34 84 50 50 72 90 36 2 54 45 7 84 71 30 100 7 31 59 69 53 45 81 44 85 21 82 18 58 96 53 56 21 91 61 38 38 70 49 53 36 97 41 53 98 28 31 30 17 71 41 17 6 55 92 35 90 24 52 6 13 99 94 82 14 23 71 62 33 68 22 76 2 21 16 57 68 88 58 30 35 5 76 18 32 57 3 79 34 29 22 96 41 65 34 64 38 49 7 12 92 46 42 100 1 15 91 61 10 9 49 21 15 15 41 37 34 87 39 60 63 34 70 15 37 50 27 31 61 62 2 97 35 24 57 75 43 72 95 56 28 66 66 62 84 35 8 67 95 56 96 42 33 93 31 72 34 85 18 3 22 41 19 38 24 52 50 58 66 89 72 82 29 56 58 73 12 15 5 74 15 48 46 98 16 13 43 43 79 98 16 42 82 15 12 2 41 5 18 43 100 10 18 92 13 14 30 73 92 93 59 78 57 88 61 18 19 79 7 75 51 49 92 22 11 77 73 38 13 48 64 59 18 97 57 36 90 12 46 59 95 73 70 96 18 77 73 43 97 8 73 37 43 95 41 2 76 28 45 28 19 73 40 41 87 78 78 89 92 4 69 85 87 88 83 63 5 61 90 72 14 12 9 92 9 12 81 31 19 68 92 98 90 67 78 41 17 87 6 4 30 23 64 64 24 22 10 14 30 15 2 9 21 83 65 80 18 2 4 45 98 69 18 96 2 95 42 96 12 9 52 49 81 27 80 69 15 44 98 40 90 87 20 89 83 71 55 26 14 17 54 82 97 85 14 59 48 56 15 3 76 92 80 55 46 61 33 47 79 32 13 14 57 29 3 46 9 10 86 46 23 12 100 11 32 71 73 80 97 68 82 21 35 62 9 3 43 14 59 48 50 29 79 54 42 36 10 88 95 72 64 2 5 88 38 72 26 34 14 89 28 24 72 30 77 79 66 44 55 77 17 20 58 86 36 40 11 35 50 9 8 29 85 42 24 20 56 24 26 28 23 79 56 43 78 83 46 83 14 60 13 92 54 7 88 30 18 93 11 37 92 20 100 53 54 77 61 61 63 25 48 9 17 13 67 57 85 44 95 47 97 46 23 70 96 52 12 54 97 97 75 92 62 74 51 66 24 76 35 32 96 93 94 52 88 36 47 5 28 76 42 92 59 24 67 100 39 66 98 97 85 85 100 88 78 68 46 39 63 59 39 39 59 61 78 38 61 12 41 6 86 19 73 17 93 9 93 11 27 18 72 69 95 89 14 19 37 56 50 33 19 13 100 85 81 41 81 73 52 48 36 27 12 92 43 77 36 91 26 18 72 57 31 67 24 85 23 74 73 93 1 22 71 33 32 76 25 65 32 71 76 97 71 24 29 32 74 8 88 97 96 92 51 6 66 24 60 63 11 5 67 29 84 23 89 80 34 55 74 71 25 13 15 29 49 25 27 74";
        //string[] sNums = nums.Split(" ");
        //len = sNums.Length;
        //int[] myArray = new int[len];
        //for(int i = 0; i < len; i++)
        //{
        //    myArray[i] = int.Parse(sNums[i]);
        //}

        // Print given array
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        
        // Selection Sort logic
        for(int i = 0; i < len-1; i++)
        {
            int minIndex = i;
            int temp = myArray[i];
            for(int j = i+1; j < len; j++)
            {
                if(myArray[j] < myArray[minIndex])
                {
                    minIndex = j;
                }
            }

            temp = myArray[i];
            myArray[i] = myArray[minIndex];
            myArray[minIndex] = temp;
        }

        // Print sorted array
        Console.WriteLine();
        Console.Write("Sorted array = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
    }
}