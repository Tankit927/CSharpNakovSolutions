// Write a program, which creates an array of 20 elements of type 
// integer and initializes each of the elements with a value equals to the 
// index of the element multiplied by 5. Print the elements to the console.

class InitArray
{
    static void Main()
    {
        int[] myArray = new int[20];

        Console.WriteLine("Program to create an array of 20 elements " +
        "of type int and initialize them with value equal to the" +
        "index multiplied by 5.");

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i*5;
        }

        foreach(int num in myArray)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
    }
}