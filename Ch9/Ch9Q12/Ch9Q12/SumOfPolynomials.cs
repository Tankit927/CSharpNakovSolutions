// Write a method that calculates the sum of two polynomials with integer 
// coefficients, for example (3x^2 + x - 3) + (x - 1) = (3x^2 + 2x - 4).

class SumOfPolynomials
{
    static void Main()
    {
        int d1, d2;

        Console.WriteLine("Program to calculate sum of two given polynomials.");
        d1 = GetInt("Degree of 1st polynomial = ", 0);
        int[] p1 = GetPolynomial(d1);

        Console.WriteLine();
        d2 = GetInt("Degree of 2nd polynomial = ", 0);
        int[] p2 = GetPolynomial(d2);

        int[] sum = Sum(p1, p2);

        Console.WriteLine();
        Console.WriteLine($"{ConvertPolyArrayToString(p1)} + {ConvertPolyArrayToString(p2)} =");
        Console.WriteLine(ConvertPolyArrayToString(sum));
    }


    static int[] GetPolynomial(int degree)
    {
        // Method to user input polynomial of given degree

        int[] p = new int[degree+1];
        InitArray(p);

        return p;
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

        for(int i = myArray.Length-1; i >= 0; i--)
        {
            myArray[i] = GetInt($"Coefficient of x^{i} = ");
        }
    }


    static int[] Sum(int[] p1, int[] p2)
    {
        // Method to return addition of two given polynomials;

        int p1Len = p1.Length;
        int p2Len = p2.Length;
        int len = p1Len > p2Len ? p1Len : p2Len;
        int[] sum = new int[len];

        for(int i = 0; i < len; i++)
        {
            if(i < p1Len && i < p2Len)
            {
                sum[i] = p1[i] + p2[i];
            }
            else if(i < p1Len && i >= p2Len)
            {
                sum[i] = p1[i];
            }
            else
            {
                sum[i] = p2[i];
            }
        }

        return sum;
    }


    static string ConvertPolyArrayToString(int[] myArray)
    {
        // Method to print given polynomial

        string myPoly = "";
        int len = myArray.Length;

        myPoly += "(";
        for(int i = len-1; i >= 0; i--)
        {
            if(i > 0)
            {
                myPoly += $"{myArray[i]:+0;-0}x^{i}";
            }
            else
            {
                myPoly += $"{myArray[i]:+0;-0}";
            }
        }

        myPoly += ")";

        return myPoly;
    }
}