// * Write a method that calculates the product of two polynomials with 
// integer coefficients, for example (3x^2 + x - 3) * (x - 1) = (3x^3 - 
// 2x^2 - 4x + 3).

class ProductOfPolynomials
{
    static void Main()
    {
        int d1, d2;

        Console.WriteLine("Program to calculate product of two given polynomials.");
        d1 = GetInt("Degree of 1st polynomial = ", 0);
        int[] p1 = InitPoly(d1);

        Console.WriteLine();
        d2 = GetInt("Degree of 2nd polynomial = ", 0);
        int[] p2 = InitPoly(d2);

        int[] p3 = ProductOfPolys(p1, p2);
        Console.WriteLine();
        Console.WriteLine($"{PolyArrayToString(p1)} * {PolyArrayToString(p2)} = ");
        Console.WriteLine(PolyArrayToString(p3));
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


    static int[] InitPoly(int degree)
    {
        // Method to initialise polynomial of given degree

        int[] p = new int[degree+1];

        for(int i = degree; i >= 0; i--)
        {
            p[i] = GetInt($"Coefficient of x^{i} = ");
        }

        return p;
    }


    static int[] ProductOfPolys(int[] p1, int[] p2)
    {
        // Method to return product of two polynomials

        int d1 = p1.Length - 1;
        int d2 = p2.Length - 1;
        int d3 = d1 + d2;
        int[] p3 = new int[d3+1];

        for(int i = 0; i <= d1; i++)
        {
            for(int j = 0; j <= d2; j++)
            {
                p3[i+j] += (p1[i] * p2[j]);
            }
        }

        return p3;
    }


    static string PolyArrayToString(int[] myArray)
    {
        // Method to return string representation of polynomial array

        string poly = "";
        int len =  myArray.Length;

        poly += "(";
        for(int i = len-1; i >= 0; i--)
        {
            if(i > 1)
            {
                poly += $"{myArray[i]:+0;-0}x^{i}";
            }
            else if(i == 1)
            {
                poly += $"{myArray[i]:+0;-0}x";
            }
            else
            {
                poly += $"{myArray[i]:+0;-0}";
            }
        }

        poly += ")";

        return poly;
    }
}