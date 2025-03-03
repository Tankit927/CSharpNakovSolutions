// Write a recursive program, which generates and prints all permutations 
// of the numbers 1, 2, …, n, for a given integer n. Example input:
// n = 3
// Example output:
// (1, 2, 3), (1, 3, 2), (2, 1, 3), (2, 3, 1), (3, 1, 2), (3, 2, 1)
// Try to find an iterative solution for generating permutations.

class PermutationWithoutRepetition
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to print permutations without repetition for " +
        "given value n");
        n = GetInt("n = ", 1);
        int[] myArray = new int[n];

        Console.WriteLine();
        Console.WriteLine($"Permutation without repetition recursively, nPk for n = {n}, k = {n}");
        GeneratePermutationWithoutRepetitionRecursively(myArray, n);

        Console.WriteLine();
        Console.WriteLine($"Permutation without repetition iteratively, nPk for n = {n}, k = {n}");
        GeneratePermutationWithoutRepetitionIteratively(myArray, n);
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


    static void GeneratePermutationWithoutRepetitionRecursively(int[] myArray, int n, int k=0)
    {
        // Method to generate permutations without repetition of n elements taken 
        // k=myArray.Length no. at a time recursively
        // nPk = n! / (n-k)!

        if(k >= myArray.Length)
        {
            PrintArray(myArray);
            return;
        }

        for(int i = 1; i <= n; i++)
        {
            if(AlreadyExist(i, k, myArray)) // If i already exist in myArray 
            {                               // before index k then continue
                continue;
            }

            myArray[k] = i;
            GeneratePermutationWithoutRepetitionRecursively(myArray, n, k+1);
        }
    }


    static void PrintArray(int[] myArray)
    {
        // Method to print given array

        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }


    static bool AlreadyExist(int i, int k, int[] myArray)
    {
        // Method to check whether i already exist in myArray before index k

        for(int j = 0; j < k && j < myArray.Length; j++)
        {
            if(myArray[j] == i)
            {
                return true;
            }
        }

        return false;
    }


    static void GeneratePermutationWithoutRepetitionIteratively(int[] myArray, int n)
    {
        // Method to generate permutation without repetition of n elements taken
        // k=myArray.Length no. at a time iteratively
        // nPk = n! / (n-k)!

        InitArray(myArray);
        PrintArray(myArray);

        int len = myArray.Length;
        int i = len - 1;
        int temp = -1;

        while(i >= 0)
        {
            if(temp == -1)
            {
                temp = myArray[i] + 1;
            }
            else
            {
                temp += 1;
            }

            if(AlreadyExist(temp, i, myArray))
            {
                continue;
            }
            else if(temp <= n)
            {
                myArray[i] = temp;
                PrintArray(myArray);
            }
            else
            {
                temp = -1;
                while(i >= 0)
                {
                    if(temp == -1)
                    {
                        temp = myArray[i] + 1;
                    }
                    else
                    {
                        temp += 1;
                    }

                    if(temp > n)
                    {
                        i -= 1;
                        temp = -1;
                    }
                    else if(AlreadyExist(temp, i, myArray))
                    {
                        continue;
                    }
                    else
                    {
                        myArray[i] = temp;
                        temp = 1;
                        for(int j = i+1; j < len && temp <= n; j++)
                        {
                            while(temp <= n)
                            {
                                if(AlreadyExist(temp, j, myArray))
                                {
                                    temp += 1;
                                    continue;
                                }
                                else
                                {
                                    myArray[j] = temp;
                                    temp = 1;
                                    break;
                                }
                            }
                        }

                        PrintArray(myArray);
                        break;
                    }
                }

                if(i >= 0)
                {
                    i = len - 1;
                    temp = -1;
                }
            }
        }
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise the given array in increasing order

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i + 1;
        }
    }
}