// Write a program, which creates square matrices like those in the 
// figures below and prints them formatted to the console. The size of the 
// matrices will be read from the console. See the examples for matrices 
// with size of 4 x 4 and make the other sizes in a similar fashion:
//
// (a) 1 5  9 13              (b) 1 8  9 16
//     2 6 10 14                  2 7 10 15
//     3 7 11 15                  3 6 11 14
//     4 8 12 16                  4 5 12 13
//
// (c) 7 11 14 16             (d) 1 12 11 10
//     4  8 12 15                 2 13 16  9
//     2  5  9 13                 3 14 15  8
//     1  3  6 10                 4  5  6  7
//

class SquareMatrices
{
    static void Main()
    {
        int s;
        bool isInt;

        Console.WriteLine("Program to print various square matrices of given size.");

        // User input size of matrix
        do
        {
            Console.Write("Size of matrix = ");
            isInt = int.TryParse(Console.ReadLine(), out s);
            if(!isInt || s < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || s < 1);

        int[,] mat = new int[s,s];

        // Logic for type (a) matrix
        {
            int num = 1;
            for(int c = 0; c < s; c++)
            {
                for(int r = 0; r < s; r++)
                {
                    mat[r,c] = num;
                    num += 1;
                }
            }

            // Print matrix
            Console.WriteLine();
            int pad = 2;
            int pow = 1;
            while(num / (int)Math.Pow(10,pow) != 0)
            {
                pow += 1;
                pad = pow + 1;
            }

            for(int r = 0; r < s; r++)
            {
                for(int c = 0; c < s; c++)
                {
                    Console.Write($"{mat[r,c]}".PadLeft(pad));
                }

                Console.WriteLine();
            }
        }
        
        // Logic for type (b) matrix
        {
            int num = 1;

            for(int c = 0, r; c < s; c++)
            {
                if(c % 2 == 0)
                {
                    r = 0;
                    while(r < s)
                    {
                        mat[r,c] = num;
                        num += 1;
                        r += 1;
                    }
                }
                else
                {
                    r = s - 1;
                    while(r >= 0)
                    {
                        mat[r,c] = num;
                        num += 1;
                        r -= 1;
                    }
                }
            }

            // Print matrix
            Console.WriteLine();
            int pad = 2;
            int pow = 1;
            while(num / (int)Math.Pow(10,pow) != 0)
            {
                pow += 1;
                pad = pow + 1;
            }

            for(int r = 0; r < s; r++)
            {
                for(int c = 0; c < s; c++)
                {
                    Console.Write($"{mat[r,c]}".PadLeft(pad));
                }

                Console.WriteLine();
            }
        }

        // Logic for type (c) matrix
        {
            int num = 1;
            for(int startRow = s-1; startRow >= 0; startRow--) // Bottom half of the matrix including diagonal
            {
                for(int r = startRow, c = 0; r < s && c < s; r++, c++)
                {
                    mat[r,c] = num;
                    num += 1;
                }
            }

            for(int startCol = 1; startCol < s; startCol++) // Top half of matrix excluding diagonal
            {
                for(int r = 0, c = startCol; r < s && c < s; r++, c++)
                {
                    mat[r,c] = num;
                    num += 1;
                }
            }

            // Print matrix
            Console.WriteLine();
            int pad = 2;
            int pow = 1;
            while(num / (int)Math.Pow(10,pow) != 0)
            {
                pow += 1;
                pad = pow + 1;
            }

            for(int r = 0; r < s; r++)
            {
                for(int c = 0; c < s; c++)
                {
                    Console.Write($"{mat[r,c]}".PadLeft(pad));
                }

                Console.WriteLine();
            }
        }

        // Logic for type (d) matrix
        {
            int num = 1;
            int rMin, rMax, cMin, cMax, rLoopMin, rLoopMax, cLoopMin, cLoopMax, rMaxTemp, rMinTemp, cMaxTemp, cMinTemp;
            rMin = cMin = rMaxTemp = rMinTemp = cMaxTemp = cMinTemp = 0;
            rMax = cMax = rLoopMax = cLoopMax = s - 1;

            // Breaking out of loop when (rLoopMin > rLoopMax || cLoopMin > cLoopMax)
            while(true)
            {
                // Row++
                rLoopMin = rMin + rMinTemp;
                cLoopMin = cMin + cMinTemp;
                if(rLoopMin > rLoopMax || cLoopMin > cLoopMax)
                {
                    break;
                }
                for(int r = rLoopMin, c = cLoopMin; rLoopMin <= r && r <= rLoopMax && cLoopMin <= c && c <= cLoopMax; r++)
                {
                    mat[r,c] = num;
                    num += 1;
                }

                // Col++
                cMinTemp += 1;
                rLoopMax = rMax - rMaxTemp;
                cLoopMin = cMin + cMinTemp;
                if(rLoopMin > rLoopMax || cLoopMin > cLoopMax)
                {
                    break;
                }
                for(int r = rLoopMax, c = cLoopMin; rLoopMin <= r && r <= rLoopMax && cLoopMin <= c && c <= cLoopMax; c++)
                {
                    mat[r,c] = num;
                    num += 1;
                }

                // Row--
                rMaxTemp += 1;
                rLoopMax = rMax - rMaxTemp;
                cLoopMax = cMax - cMaxTemp;
                if(rLoopMin > rLoopMax || cLoopMin > cLoopMax)
                {
                    break;
                }
                for(int r = rLoopMax, c = cLoopMax; rLoopMin <= r && r <= rLoopMax && cLoopMin <= c && c <= cLoopMax; r--)
                {
                    mat[r,c] = num;
                    num += 1;
                }

                // Col--
                cMaxTemp += 1;
                rLoopMin = rMin + rMinTemp;
                cLoopMax = cMax - cMaxTemp;
                if(rLoopMin > rLoopMax || cLoopMin > cLoopMax)
                {
                    break;
                }
                for(int r = rLoopMin, c = cLoopMax; rLoopMin <= r && r <= rLoopMax && cLoopMin <= c && c <= cLoopMax; c--)
                {
                    mat[r,c] = num;
                    num += 1;
                }

                rMinTemp += 1;
            }

            // Print matrix
            Console.WriteLine();
            int pad = 2;
            int pow = 1;
            while(num / (int)Math.Pow(10,pow) != 0)
            {
                pow += 1;
                pad = pow + 1;
            }

            for(int r = 0; r < s; r++)
            {
                for(int c = 0; c < s; c++)
                {
                    Console.Write($"{mat[r,c]}".PadLeft(pad));
                }

                Console.WriteLine();
            }
        }
    }
}