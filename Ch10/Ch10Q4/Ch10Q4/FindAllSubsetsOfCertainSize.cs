﻿// You are given a set of strings. Write a recursive program, which 
// generates all subsets, consisting exactly k strings chosen among the 
// elements of this set. Sample input: 
// strings = {'test', 'rock', 'fun'} 
// k = 2 
// Sample output: 
// (test rock), (test fun), (rock fun) 
// Think about and implement an iterative algorithm as well.

class FindAllSubsetsOfCertainSize
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to find all subsets of certain size from " +
        "of given array of strings.");
        n = GetInt("Length of array = ", 1);

        Console.WriteLine("Enter elements in the array");
        string[] set = new string[n];
        InitStringArray(set);
        
        Console.WriteLine();
        k = GetInt("Size of subsets to be found = ", 1, n);
        int[] subset = new int[k];

        Console.WriteLine();
        Console.WriteLine("Given array:");
        PrintArray(set);

        Console.WriteLine();
        Console.WriteLine($"Subsets of size {k} recursively:");
        GenerateCombinationWithoutRepetitionRecursively(set, subset, n-1);

        Console.WriteLine();
        Console.WriteLine($"Subsets of size {k} iteratively:");
        GenerateCombinationWithoutRepetitionIteratively(set, subset, n-1);
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


    static void GenerateCombinationWithoutRepetitionRecursively(string[] set, int[] myArray, int n, int k=0, int counter=0)
    {
        // Method to generate combination of n elements taken myArray.Length times
        // without repetition
        // nCk = n! / k!(n-k)!

        if(k >= myArray.Length)
        {
            PrintSubset(set, myArray);
            return;
        }

        for(int i = counter; i <= n; i++)
        {
            myArray[k] = i;
            GenerateCombinationWithoutRepetitionRecursively(set, myArray, n, k+1, i+1);
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


    static void PrintArray(string[] myArray)
    {
        // Method to print given array

        foreach(string i in myArray)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }


    static string GetString(string prompt)
    {
        // Method to user input non-empty string

        string s = "";

        do
        {
            Console.Write(prompt);
            s = Console.ReadLine();
            if(s == "")
            {
                Console.WriteLine("\nEnter something bruh!");
            }
        }
        while(s == "");

        return s;
    }


    static void InitStringArray(string[] myArray)
    {
        // Method to initialise given string array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetString($"myArray[{i}] = ");
        }
    }


    static void PrintSubset(string[] set, int[] subset)
    {
        // Method to print subset

        for(int i = 0; i < subset.Length; i++)
        {
            Console.Write($"{set[subset[i]]} ");
        }

        Console.WriteLine();
    }


    static void GenerateCombinationWithoutRepetitionIteratively(string[] set, int[] myArray, int n)
    {
        // Method to generate combination without repetition of n elements taken
        // myArray.Length times at a time
        // nCk = n! / k!(n-k)!

        InitArray(myArray);
        PrintSubset(set, myArray);

        int len = myArray.Length;
        int i = len - 1;

        while(i >= 0)
        {
            i = len - 1;
            if(myArray[i]+1 <= n)
            {
                myArray[i] += 1;
                PrintSubset(set, myArray);
            }
            else
            {
                while(i >= 0)
                {
                    if(myArray[i]+1 <= n)
                    {
                        myArray[i] += 1;
                        for(int j = i+1; j < len; j++)
                        {
                            if(myArray[j-1]+1 <= n)
                            {
                                myArray[j] = myArray[j-1] + 1;
                                if(j == len-1)
                                {
                                    PrintSubset(set, myArray);
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                        break;
                    }
                    else
                    {
                        i -= 1;
                    }
                }
            }
        }
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise the given array in increasing order

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i;
        }
    }
}