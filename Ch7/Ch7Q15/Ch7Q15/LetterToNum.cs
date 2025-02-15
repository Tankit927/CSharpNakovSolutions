// Write a program, which creates an array containing all Latin letters. 
// The user inputs a word from the console and as result the program 
// prints to the console the indices of the letters from the word.

class LetterToNum
{
    static void Main()
    {
        string word;

        Console.WriteLine("Program to convert given word to numbers");

        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // User inputs
        do
        {
            Console.Write("Enter something: ");
            word = Console.ReadLine();
            if(word == "")
            {
                Console.WriteLine($"\nI said");
            }
        }
        while(word == "");

        // Logic to convert letters to nums
        string nums = "";

        word = word.ToUpper();
        foreach(char i in word)
        {
            for(int j = 0; j < letters.Length; j++)
            {
                if(i == letters[j])
                {
                    nums += j;
                    break;
                }
                else if(j == letters.Length - 1)
                {
                    nums += " ";
                }
            }
        }

        // Print result
        Console.WriteLine();
        Console.WriteLine(nums);
    }
}