// Pascal Triangle

class PascalTriangle
{
    static void Main()
    {
        int h;
        bool isInt;

        Console.WriteLine("Program to print pascal triangle of given height h");
        do
        {
            Console.Write("h = ");
            isInt = int.TryParse(Console.ReadLine(), out h);
            if(!isInt || h < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,{int.MaxValue}]");
            }
        }
        while(!isInt || h < 1);

        // Declare jagged array for pascal triangle
        int[][] P = new int[h][];
        for(int i = 0; i < h; i++)
        {
            P[i] = new int[i+1];
        }

        // Pascal triangle logic
        P[0][0] = 1;
        int largest = 1;
        for(int r = 1; r < h; r++)
        {
            for(int c = 0; c <= r; c++)
            {
                if(c == 0 || c == r)
                {
                    P[r][c] = 1;
                }
                else
                {
                    P[r][c] = P[r-1][c] + P[r-1][c-1];
                }

                if(P[r][c] > largest)
                {
                    largest = P[r][c];
                }
            }
        }

        // Calculate padding for pascal triangle
        int pad = 3;
        for(int pow = 2; pow < int.MaxValue; pow++)
        {
            if(largest / (int)Math.Pow(10,pow) == 0)
            {
                pad = pow + 2;
                break;
            }
        }

        // Print left aligned pascal triangle
        for(int r = 0; r < h; r++)
        {
            for(int c = 0; c <= r; c++)
            {
                Console.Write($"{P[r][c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }

        // Print right aligned pascal triangle
        Console.WriteLine();
        for(int r = 0; r < h; r++)
        {
            for(int c = 0; c <= r; c++)
            {
                if(c == 0)
                {
                    Console.Write($"{P[r][c]}".PadLeft(pad*(h-r)));
                }
                else
                {
                    Console.Write($"{P[r][c]}".PadLeft(pad));
                }
            }

            Console.WriteLine();
        }

        // Print center aligned pascal triangle
        Console.WriteLine();
        for(int r = 0; r < h; r++)
        {
            for(int c = 0; c <= r; c++)
            {
                if(c == 0)
                {
                    Console.Write($"{P[r][c]}".PadLeft((pad*(h-r))/2));
                }
                else
                {
                    Console.Write($"{P[r][c]}".PadLeft(pad));
                }
            }

            Console.WriteLine();
        }
    }
}