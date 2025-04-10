// Write a program that extracts all e-mail addresses from a text. These 
// are all substrings that are limited on both sides by text end or separator 
// between words and match the shape <sender>@<host>…<domain>. 
// Sample text: 
// Please contact us by phone (+001 222 222 222) or by email at 
// example@gmail.com or at test.user@yahoo.co.uk. This is not 
// email: test@test. This also: @gmail.com. Neither this: 
// a@a.b. 
// Extracted e-mail addresses from the sample text: 
// example@gmail.com 
// test.user@yahoo.co.uk 

using System.Text.RegularExpressions;

class Emails
{
    static void Main()
    {
        string s = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b. Another email to check is text....@gmail.com or test...crap@gmail.com and this test.man@gmail...com..in. Ha ha email go brrr.... suzy.cozy.let.the.gate@gmail.com. What about getRekt.@gmail.com or getrekt_@gmail.com";
        Console.WriteLine(s);
        Console.WriteLine();
        // pattern to match valid email ids
        // \b([\w]+\.?[\w]*\.?)+ - to match username
        // \b@\b - to match @
        // [\w]{2,}\.{1}([\w]{2,}\.?)+\b - to match domain
        string pattern = @"\b([\w]+\.?[\w]*\.?)+\b@\b[\w]{2,}\.{1}([\w]{2,}\.?)+\b";
        MatchCollection matches = Regex.Matches(s, pattern);
        foreach(Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}