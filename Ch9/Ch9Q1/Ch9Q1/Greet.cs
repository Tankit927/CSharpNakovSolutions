// Write a code that by given name prints on the console "Hello, <name>!" 
// (for example: "Hello, Peter!").

class Greet
{
    static void Main()
    {
        Console.WriteLine("Program to greet people.");
        Greetem(GetString("Name = "));
    }


    static void Greetem(string name)
    {
        // Method to greet people

        Console.WriteLine($"Hello, {name}!");
    }


    static string GetString(string prompt)
    {
        // Method to user input strings

        string myString = "";
        
        do
        {
            Console.Write(prompt);
            myString = Console.ReadLine();
            if(myString == "")
            {
                Console.WriteLine($"\nEnter something bruh!");
            }
        }
        while(myString == "");

        return myString;
    }
}