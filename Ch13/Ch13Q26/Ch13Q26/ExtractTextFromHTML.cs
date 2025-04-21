// Write a program that extracts all the text without any tags and 
// attribute values from an HTML document. 
// Sample text: 
// <html> 
// <head><title>News</title></head> 
// <body><p><a href="http://softuni.org">Software 
// University</a>aims to provide free real-world practical 
// training for young people who want to turn into 
// skillful software engineers.</p></body> 
// </html> 
// Sample result: 
// News 
// Software University aims to provide free real-world 
// practical training for young people who want to turn into 
// skillful software engineers.

using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        string s = "<html><head><title>News</title></head><body><p><a href=\"http://softuni.org\">Software University</a>aims to provide free real-world practical training for young people who want to turn into skillful software engineers.</p></body></html>";
        Console.WriteLine(s);

        string text = ExtractText(s);
        Console.WriteLine();
        Console.WriteLine("Extract text manually:");
        Console.WriteLine(text);

        // Pattern to match text between > and <
        string pattern = @"(?'Open'>)([^<>]+)(?'Close-Open'<)";
        MatchCollection matches = Regex.Matches(s, pattern);
        Console.WriteLine();
        Console.WriteLine("Extract text using regex:");
        foreach(Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }


    static string ExtractText(string s)
    {
        // Method to extract text from html document string
        //
        // Shamefully copy/pasting the hint:
        // Scan the text letter by letter and at all times keep in a variable 
        // whether currently there is an opening tag which has not been closed or 
        // not. If you have "<", enter in "opening tag" mode. If you have ">", exit 
        // the "opening tag" mode. If you have a letter, add it to the result only if 
        // the program is not in "opening tag". After closing a tag you can add a 
        // space in order not to "stick" the text before and after the tag.

        StringBuilder sb = new();
        char currentState, lastState;
        currentState = lastState = ' ';

        foreach(char c in s)
        {
            if(c == '<')
            {
                lastState = currentState;
                currentState = c;
            }
            else if(c == '>')
            {
                lastState = currentState;
                currentState = c;
            }

            if(currentState == '>' && c != '>')
            {
                if(lastState == '<')
                {
                    sb.Append(' ');
                    lastState = currentState;
                }

                sb.Append(c);
            }
        }

        return sb.ToString().Trim();
    }
}