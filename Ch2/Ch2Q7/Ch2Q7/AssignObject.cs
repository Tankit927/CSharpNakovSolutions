// Declare two variables of type string with values "Hello" and "World". 
// Declare a variable of type object. Assign the value obtained of 
// concatenation of the two string variables (add space if necessary) to this 
// variable. Print the variable of type object.

class AssignObject
{
    static void Main()
    {
        string greeting = "Hello";
        string noun = "World";
        object sentence;

        sentence = greeting + " " + noun;
        Console.WriteLine(sentence);
    }
}