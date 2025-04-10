// Write a program that parses an URL in following format: 
// [protocol]://[server]/[resource] 
// It should extract from the URL the protocol, server and resource parts. 
// For example, when http://www.cnn.com/video is passed, the result is: 
// [protocol]="http" 
// [server]="www.cnn.com" 
// [resource]="/video"


using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Program to parse given URL if following format:");
        Console.WriteLine("[protocol]://[server]/[resource]");
        string s = GetString("Enter URL: ");

        string[] url = GetURL(s);

        Console.WriteLine();
        Console.WriteLine("Manually:");
        Console.WriteLine($"[protocol]: {url[0]}");
        Console.WriteLine($"[server]: {url[1]}");
        Console.WriteLine($"[resource]: {url[2]}");
        
        string pattern = @"(?'protocol'^\w+)://(?'server'[\w\.]+)(?'resource'.+$)";
        Match match = Regex.Match(s, pattern);
        Console.WriteLine();
        Console.WriteLine("Using regex:");
        Console.WriteLine($"[protocol]: {match.Groups["protocol"].Value}");
        Console.WriteLine($"[server]: {match.Groups["server"].Value}");
        Console.WriteLine($"[resource]: {match.Groups["resource"].Value}");
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


    static string[] GetURL(string s)
    {
        // Method to separate protocol, server and resource from given URL

        string[] url = new string[3];

        // Get protocol
        int i = GetIndexOfCertainOccuranceOf(':', s);
        if(i >= 0)
        {
            url[0] = s.Substring(0, i);
        }
        

        // Get server and resource
        i = GetIndexOfCertainOccuranceOf('/', s, 2);
        if(i >= 0)
        {
            int j = GetIndexOfCertainOccuranceOf('/', s, 3);
            if(j >= 0)
            {
                url[1] = s.Substring(i+1, j-i-1);
                url[2] = s.Substring(j);          
            }
        }

        return url;
    }


    static int GetIndexOfCertainOccuranceOf(char c, string s, int count=1)
    {
        // Method to find index of certain occurance of given character in
        // given string

        int index = -1;

        do
        {
            index = s.IndexOf(c, index+1);
            count -= 1;
        }
        while(index >= 0 && index < s.Length-1 && count > 0);

        return index;
    }
}