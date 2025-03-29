// Exploring:
// 1. string initialization
// 2. string comparison
// 3. string operations
// 4. StringBuilder
//    - Initialization
//    - Operations
// 5. Regular Expressions

using System.Text;

class Program
{
    static void Main()
    {
        const int PAD = 40;
        const int S_NO_PAD = 6;
        const int NO_OF_HYPHEN = 100;
        int count = 1;
        
        // Declaring and initializing string
        string s1 = "Ankit"; // Initializing with literal value
        string s2 = new('a', 4); // "aaaa" equivalent to {new string('a', 4);}
        char[] cArray = {'S','u','p','!',' ','j','u','s','t',' ','m','e','s','s','i','n','g',' ','w','i','t','h',' ','s','t','r','i','n','g','s',' ','i','n',' ','C','#','.'};
        string s3 = new(cArray); // Initializing with char[]
        string s4 = new(cArray, 10, 20); // Initializing with char[], startIndex, length
        string s7 = string.Empty;

        Console.WriteLine("Ways to initialize string variable:");
        Console.Write("S.No.".PadRight(S_NO_PAD)); Console.Write("Value of string variable".PadRight(PAD)); Console.WriteLine("How its initialized");
        Console.WriteLine(new string('-', NO_OF_HYPHEN));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s1.PadRight(PAD)); Console.WriteLine($"string s = \"{s1}\";");
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s2.PadRight(PAD)); Console.WriteLine($"string s = new('a', 4);");
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s3.PadRight(PAD)); Console.WriteLine($"string s = new(charArray);");
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s4.PadRight(PAD)); Console.WriteLine($"string s = new(charArray,startIndex,length);");
        char[] myArray = {'a','r','r','a','y','\0'}; // Last character needs to be '\0' null character to indicate the pointer to stop here
        unsafe
        {
            fixed(char* ptr = myArray)
            {
                string s5 = new(ptr); // Initializing with pointer to first character of myArray
                Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s5.PadRight(PAD)); Console.WriteLine($"string s = new(charPointer of first element of charArray);");

                string s6 = new(ptr, 2, 3); // Initializing with pointer to first character of myArray, startIndex, length
                Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s6.PadRight(PAD)); Console.WriteLine($"string s = new(charPointer,startIndex,length);");
            }
        }

        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s7.PadRight(PAD)); Console.WriteLine($"string s = string.Empty;");

        unsafe
        {
            // The last element needs to be null character '\0' because
            // the pointer will search for first '\0' and stops there
            // if its not present it will continue searching for it in memory
            char[] charArray = {'a','r','r','a','y','\0'};

            fixed(char* ptr = charArray) // ptr is pointer to first element in cArray
            {
                string s = new string(ptr);
                // Do stuff with string s
            }

            fixed(char* ptr = &charArray[0]) // ptr can also start at any given index like &cArray[3]
            {
                string s = new string(ptr);
                // Do stuff with string s
            }
        }


        // String comparison
        s1 = new StringBuilder("Ankit").ToString();
        object obj = "Ankit";
        object obj2 = "aNkIt";
        count = 1;
        int pad = 70;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("String comparison for equality");

        Console.WriteLine();
        Console.WriteLine($"s1 = {s1}");
        Console.WriteLine($"obj = {obj}");

        Console.WriteLine();
        Console.Write("S.No.".PadRight(S_NO_PAD)); Console.Write("Comparison for equality".PadRight(pad)); Console.WriteLine("Result");
        Console.WriteLine(new string('-', NO_OF_HYPHEN));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write("string s1 == \"ANKIT\"".PadRight(pad)); Console.WriteLine(s1 == "ANKIT");
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write("string s1 == Object obj".PadRight(pad)); Console.WriteLine(s1 == obj);
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write("s1.Equals(\"ANKIT\",StringComparison.InvariantCultureIgnoreCase)".PadRight(pad)); Console.WriteLine(s1.Equals("ANKIT", StringComparison.InvariantCultureIgnoreCase));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write("string.Equals(s1,\"ANKIT\")".PadRight(pad)); Console.WriteLine(string.Equals(s1,"ANKIT"));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write("string.Equals(s1,obj)".PadRight(pad)); Console.WriteLine(string.Equals(s1,obj));

        // String comparison for lexical ordering
        s1 = "abcd";
        s2 = "ABCD";
        s3 = "efgh";
        count = 1;
        pad = 50;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("String comparison for lexical order");

        Console.WriteLine();
        Console.Write("S.No.".PadRight(S_NO_PAD)); Console.Write("Comparison for lexical order".PadRight(pad)); Console.WriteLine("Result");
        Console.WriteLine(new string('-', NO_OF_HYPHEN));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write($"string.Compare({s1},{s2})".PadRight(pad)); Console.WriteLine(string.Compare(s1,s2));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write($"string.Compare({s1},{s2},ignoreCase:true)".PadRight(pad)); Console.WriteLine(string.Compare(s1,s2,true));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write($"string.Compare({s3},{s2},ignoreCase:true)".PadRight(pad)); Console.WriteLine(string.Compare(s3,s2,true));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write($"{s1}.CompareTo({s2})".PadRight(pad)); Console.WriteLine(s1.CompareTo(s2));

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("There are so many methods, properties that I'm not going to list.");
        Console.WriteLine();
        Console.WriteLine("Type \"string.\" in any code editor with intellisense");
        Console.WriteLine("To view all static string methods");
        Console.WriteLine();
        Console.WriteLine("Type \"stringVariable.\"");
        Console.WriteLine("To view all string instance methods and properties");

        // Console.WriteLine();
        // Console.WriteLine();
        // Console.WriteLine();
        // Console.WriteLine(string.Compare(null,null,true));
    }
}