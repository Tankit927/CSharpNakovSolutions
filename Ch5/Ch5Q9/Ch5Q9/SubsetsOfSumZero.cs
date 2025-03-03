// We are given 5 integer numbers. Write a program that finds those 
// subsets whose sum is 0. Examples:
// - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 
// is 0.
// - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets 
// with sum 0.

class SubsetsOfSumZero
{
    static void Main()
    {
        int n1, n2, n3, n4, n5;
        bool isInt;
        bool subsetFound = false;

        Console.WriteLine("Program to find subsets of sum 0 from given five numbers");
        Console.Write("n1 = ");
        isInt = int.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine(isInt ? "" : "Invalid number");
        Console.Write("n2 = ");
        isInt = int.TryParse(Console.ReadLine(), out n2);
        Console.WriteLine(isInt ? "" : "Invalid number");
        Console.Write("n3 = ");
        isInt = int.TryParse(Console.ReadLine(), out n3);
        Console.WriteLine(isInt ? "" : "Invalid number");
        Console.Write("n4 = ");
        isInt = int.TryParse(Console.ReadLine(), out n4);
        Console.WriteLine(isInt ? "" : "Invalid number");
        Console.Write("n5 = ");
        isInt = int.TryParse(Console.ReadLine(), out n5);
        Console.WriteLine(isInt ? "" : "Invalid number");

        Console.WriteLine("Subsets with sum 0 are:");
        if(n1 == 0)
        {
            subsetFound = true;
            Console.WriteLine(n1);
        }
        if(n2 == 0)
        {
            subsetFound = true;
            Console.WriteLine(n2);
        }
        if(n3 == 0)
        {
            subsetFound = true;
            Console.WriteLine(n3);
        }
        if(n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine(n4);
        }
        if(n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine(n5);
        }
        if(n1 + n2 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}");
        }
        if(n1 + n3 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n3}");
        }
        if(n1 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n4}");
        }
        if(n1 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n5}");
        }
        if(n2 + n3 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n3}");
        }
        if(n2 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n4}");
        }
        if(n2 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n5}");
        }
        if(n3 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n3}, {n4}");
        }
        if(n3 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n3}, {n5}");
        }
        if(n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n4}, {n5}");
        }
        if(n1 + n2 + n3 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n3}");
        }
        if(n1 + n2 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n4}");
        }
        if(n1 + n2 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n5}");
        }
        if(n1 + n3 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n3}, {n4}");
        }
        if(n1 + n3 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n3}, {n5}");
        }
        if(n1 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n4}, {n5}");
        }
        if(n2 + n3 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n3}, {n4}");
        }
        if(n2 + n3 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n3}, {n5}");
        }
        if(n2 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n4}, {n5}");
        }
        if(n3 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n3}, {n4}, {n5}");
        }
        if(n1 + n2 + n3 + n4 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n3}, {n4}");
        }
        if(n1 + n2 + n3 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n3}, {n5}");
        }
        if(n1 + n2 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n4}, {n5}");
        }
        if(n1 + n3 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n3}, {n4}, {n5}");
        }
        if(n2 + n3 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n2}, {n3}, {n4}, {n5}");
        }
        if(n1 + n2 + n3 + n4 + n5 == 0)
        {
            subsetFound = true;
            Console.WriteLine($"{n1}, {n2}, {n3}, {n4}, {n5}");
        }
        if(!subsetFound)
        {
            Console.WriteLine("No subset found");
        }
    }
}
