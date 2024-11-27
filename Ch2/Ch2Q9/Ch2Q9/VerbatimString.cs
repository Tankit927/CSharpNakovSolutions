// Declare two variables of type string and assign them a value “The 
// "use" of quotations causes difficulties.” (without the outer quotes). 
// In one of the variables use quoted string and in the other do not use it.

class VerbatimString
{
    static void Main()
    {
        string regularString = "The \"use\" of quotations causes difficulties.";
        string verbatimString = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine($"Regular string: {regularString}\n" +
        $"Verbatim string: {verbatimString}");
    }
}