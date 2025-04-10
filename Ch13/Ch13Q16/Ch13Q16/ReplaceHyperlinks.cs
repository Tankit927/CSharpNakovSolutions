// Write a program that replaces all hyperlinks in a HTML document 
// consisting of <a href="…">…</a> and hyperlinks in "forum" style, which 
// look like [URL=…]…[/URL]. 
// Sample text: 
// <p>Please visit <a href="http://softuni.org">our site</a> to 
// choose a training course. Also visit <a href= 
// "http://forum.softuni.org">our forum</a> to discuss the 
// courses.</p> 
// Sample result: 
// <p>Please visit [URL=http://softuni.org]our site[/URL] to 
// choose a training course. Also visit [URL= 
// http://forum.softuni.org]our forum[/URL] to discuss the 
// courses.</p>

using System.Text;
using System.Text.RegularExpressions;

class ReplaceHyperlinks
{
    static void Main()
    {
        Console.WriteLine("Program to replace all <a href=\"...\"></a> with [URL=...][/URL]");
        string s = GetString("Enter html: ");

        Console.WriteLine();
        Console.WriteLine("Manually:");
        Console.WriteLine(Replace_href_With_url(s));

        string pattern = @"</a>";
        string result = Regex.Replace(s, pattern, "[/URL]");

        // pattern2 to match <a href="http://someURL/home">
        // (<a\s+href\s*=\s*"") - to match <a href="
        // (\b.*?) - to match URL
        // ("") - to match "
        string pattern2 = @"(<a\s+href\s*=\s*"")(\b.*?)("")";
        result = Regex.Replace(result, pattern2, m => $"[URL={m.Groups[2].Value}]");
        Console.WriteLine();
        Console.WriteLine("Using regex:");
        Console.WriteLine(result);
    }


    static string GetString(string prompt)
    {
        // Method to user input string

        string? s;

        do
        {
            Console.Write(prompt);
            s = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("\nEnter something bruh!");
            }
        }
        while(string.IsNullOrWhiteSpace(s));

        return s;
    }


    static string Replace_href_With_url(string s)
    {
        // Method to replace href links with url links

        StringBuilder sb = new(s);
        
        sb = sb.Replace("<a href=\"", "[URL=");
        sb = sb.Replace("\">", "]");
        sb = sb.Replace("</a>", "[/URL]");

        return sb.ToString();
    }
}