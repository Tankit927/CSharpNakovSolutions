// Implement the merge-sort algorithm recursively. In it the initial array 
// is divided into two equal in size parts, which are sorted (recursively via 
// merge-sort) and after that the two sorted parts are merged in order to 
// get the whole sorted array.

class SortUsingMergeSort
{
    static void Main()
    {
        int[] array1 = {4,5,2,10,9,8,7,6,1,3};

        Console.WriteLine("Program to sort given array of integers using merge sort");

        Console.WriteLine();
        Console.WriteLine("Given array:");
        PrintArray(array1);
        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        SortArray(array1);
        PrintArray(array1);
    }


    static void SortArray(params int[] myArray)
    {
        // Method to sort given array

        int len = myArray.Length;
        int[] tempArray = new int[len];
        CopyArray(myArray, tempArray);
        MergeSort(myArray, tempArray, 0, len);
    }


    static void CopyArray(int[] A, int[] B)
    {
        // Method to copy array A to B

        int len = A.Length;

        if(B.Length != len)
        {
            return;
        }

        for(int i = 0; i < len; i++)
        {
            B[i] = A[i];
        }
    }


    static void MergeSort(int[] A, int[] B, int start, int end)
    {
        // A is given array, B is temporary array
        // start is inclusive
        // end is exclusive
        // left half [start ... mid-1]
        // right half [mid ... end-1]

        int mid = (end - start) / 2;

        if(mid < 1)
        {
            return;
        }

        mid += start;
        MergeSort(A, B, start, mid); // left half
        MergeSort(A, B, mid, end); // right half
        Merge(A, B, start, mid, end); // merge left and right half
    }


    static void Merge(int[] A, int[] B, int start, int mid, int end)
    {
        // Method to merge A into B then copy B to A
        // start is inclusive
        // end is exclusive
        // left half [start ... mid-1]
        // right half [mid ... end-1]

        int i, k;
        i = k = start;
        int j = mid;

        while(k < end)
        {
            if(i < mid && (j >= end || A[i] < A[j]))
            {
                B[k] = A[i];
                k += 1;
                i += 1;
            }
            else
            {
                B[k] = A[j];
                k += 1;
                j += 1;
            }
        }

        CopyArray(B, A);
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
}