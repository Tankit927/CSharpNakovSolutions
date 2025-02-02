// * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
// q+1, …, q+k-1} of a given 32-bit unsigned integer.

class ExchangeBits
{
    static void Main()
    {
        uint n;
        bool isUint;

        Console.WriteLine("Program to exchange bits {p, p+1, ... , p+k-1} " +
        "with bits {q, q+1, ... , q+k-1} of a given 32-bit unsigned integer.");
        do
        {
            Console.Write("n = ");
            isUint = uint.TryParse(Console.ReadLine(), out n);
            if(!isUint)
            {
                Console.WriteLine($"\nEnter a valid integer in range [{uint.MinValue},{uint.MaxValue}]");
            }
        }
        while(!isUint);

        int p, q, k;
        bool isInt;
        do
        {
            Console.Write("p = ");
            isInt = int.TryParse(Console.ReadLine(), out p);
            if(!isInt || p < 1 || p > 32)
            {
                Console.WriteLine($"\nEnter a valid interger in range [1,32]");
            }
        }
        while(!isInt || p < 1 || p > 32);

        do
        {
            Console.Write("q = ");
            isInt = int.TryParse(Console.ReadLine(), out q);
            if(!isInt || q < 1 || q > 32)
            {
                Console.WriteLine($"\nEnter a valid interger in range [1,32]");
            }
        }
        while(!isInt || q < 1 || q > 32);

        int greaterOf_p_q = ((p > q) ? p : q);
        int kMax = 32 - greaterOf_p_q + 1;
        do
        {
            Console.Write("k = ");
            isInt = int.TryParse(Console.ReadLine(), out k);
            if(!isInt || k < 1 || k > kMax)
            {
                Console.WriteLine($"\nEnter a valid interger in range [1,{kMax}]");
            }
        }
        while(!isInt || k < 1 || k > kMax);

        uint m = n;
        for(int i = 0, P = p, Q = q; i < k; i++, P++, Q++)
        {
            // Identifying bit at P position
            uint P_mask = 1U << (P-1);
            int P_bit = (((m & P_mask) == 0) ? 0 : 1);

            // Identifying bit at Q position
            uint Q_mask = 1U << (Q-1);
            int Q_bit = (((m & Q_mask) == 0) ? 0 : 1);

            // Changing bits if they are different
            if(P_bit != Q_bit)
            {
                m ^= P_mask;
                m ^= Q_mask;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"p = {p}, q = {q}, k = {k}");
        Console.WriteLine($"n = {n}");
        Console.WriteLine($"m = {m}");
    }
}