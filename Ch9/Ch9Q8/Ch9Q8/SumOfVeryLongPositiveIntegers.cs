// Write a method that calculates the sum of two very long positive 
// integer numbers. The numbers are represented as array digits and 
// the last digit (the ones) is stored in the array at index 0. Make the 
// method work for all numbers with length up to 10,000 digits.

class SumOfVeryLongPositiveIntegers
{
    static void Main()
    {
        string num1, num2, sum;

        Console.WriteLine("Program to sum two very long positive integers upto " +
        "10,000 digits.");
        num1 = GetLongInt("Num1 = ");
        num2 = GetLongInt("Num2 = ");
        sum = Sum(num1, num2);
        Console.WriteLine($"Sum = {sum}");
    }


    static int[] StringToReversedArray(string numString)
    {
        // Method to convert given string to reversed integer array of length 10,000

        int arrayLen = 10_000;
        int stringLen = numString.Length;
        int[] num = new int[10_000];

        for(int i = stringLen-1, j = 0; i >= 0 && j < arrayLen; i--, j++)
        {
            num[j] = Convert.ToInt32(numString[i].ToString());
        }

        return num;
    }


    static string IntArrayToString(int[] myArray)
    {
        // Method to convert given reversed int array to string

        string numString = "";

        for(int i = myArray.Length-1; i >= 0; i--)
        {
            if(myArray[i] != 0)
            {
                for(int j = i; j >= 0; j--)
                {
                    numString += myArray[j];
                }

                break;
            }
        }

        return numString;
    }


    static string GetLongInt(string prompt)
    {
        // Method to user input long positive integer upto 10,000 digits

        string num = "";
        bool isInteger = true;
        int maxDigits = 10_000;

        do
        {
            Console.Write(prompt);
            num = Console.ReadLine();
            foreach(char c in num)
            {
                if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9')
                {
                    isInteger = false;
                    break;
                }
            }

            if(num == "" || num.Length > maxDigits || !isInteger)
            {
                Console.WriteLine($"\nEnter a valid positive integer upto {maxDigits} digits");
            }
        }
        while(num == "" || num.Length > maxDigits || !isInteger);

        return num;
    }


    static string Sum(string n1, string n2)
    {
        // Method to sum two long positive integers with max sum upto 10,000 digits

        int[] num1 = StringToReversedArray(n1);
        int[] num2 = StringToReversedArray(n2);
        int len = num1.Length;
        int[] sum = new int[len];

        for(int i = 0, s = 0, c = 0; i < len; i++)
        {
            s = num1[i] + num2[i] + c;
            c = s / 10;
            s %= 10;
            sum[i] = s;
            s = 0;
        }

        return IntArrayToString(sum);
    }
}