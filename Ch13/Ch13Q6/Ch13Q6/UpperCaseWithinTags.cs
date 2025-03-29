// A text is given. Write a program that modifies the casing of letters to 
// uppercase at all places in the text surrounded by <upcase> and 
// </upcase> tags. Tags cannot be nested. 
// Example: 
// We are living in a <upcase>yellow submarine</upcase>. We 
// don't have <upcase>anything</upcase> else. 
// Result: 
// We are living in a YELLOW SUBMARINE. We don't have ANYTHING 
// else.


using System.Text;

class UpperCaseWithinTags
{
    static void Main()
    {
        // string s = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        // string s = "<upcase>Wikipedia</upcase> has been praised for enabling the <upcase>democratization of knowledge,<upcase> its extensive coverage, unique structure, and culture. Wikipedia has been censored by some national governments,<upcase> ranging from specific</upcase> pages to the entire site.[7][8] Although Wikipedia's volunteer editors have written extensively on a wide variety of topics, the encyclopedia has been criticized for systemic bias, such</upcase> as a gender bias against women and geographical bias against the Global South (Eurocentrism).[9][10] While the reliability of Wikipedia was</upcase> frequently criticized in the 2000s, it has improved over time, receiving greater praise from the late 2010s onward,[4][11][12] while becoming an important fact-checking site</upcase>.[13][14] Articles on breaking news are often accessed as sources for up-to-date information about <upcase>those</upcase> events.";

        string s;

        Console.WriteLine("Program to UPPERCASE everything between given start tag " +
        "end tag in given string");
        s = GetString("Enter string: ");

        Console.WriteLine();
        string startTag = GetString("Start tag: ");

        Console.WriteLine();
        string endTag = GetString("End tag: ");

        Console.WriteLine();
        Console.WriteLine("Given string:");
        Console.WriteLine(s);

        Console.WriteLine();
        Console.WriteLine("Formatted string:");
        Console.WriteLine(ConvertToUpper(s, startTag, endTag));
    }


    static string GetString(string prompt)
    {
        // Method to user input string

        string s;

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


    static string ConvertToUpper(string s, string startTag, string endTag)
    {
        // Method to uppercase everything within startTag and endTag
        // No nesting of tags

        StringBuilder sb = new(s);
        int len = sb.Length;
        int startTagLen = startTag.Length;
        int endTagLen = endTag.Length;
        int startTagIndex, endTagIndex, index;
        startTagIndex = endTagIndex = index = 0;

        while(startTagIndex > -1 && endTagIndex > -1 && index < len)
        {
            startTagIndex = IndexOf(sb, startTag, index);
            endTagIndex = IndexOf(sb, endTag, index);

            // Uppercase everything between
            // (startTagIndex + startTagLen) and (endTagIndex - 1) inclusively
            if(startTagIndex > -1 && endTagIndex > startTagIndex)
            {
                int tempStartIndex = startTagIndex + startTagLen;
                int tempCount = (endTagIndex - 1) - (startTagIndex + startTagLen) + 1;
                sb.Replace(Substring(sb, tempStartIndex, tempCount), Substring(sb, tempStartIndex, tempCount).ToUpperInvariant(), tempStartIndex, tempCount);

                index = endTagIndex + endTagLen; // Update index before removing startTag and endTag
                sb.Remove(startTagIndex, startTagLen); // Remove startTag
                endTagIndex -= startTagLen; // New endTagIndex after removing startTag
                sb.Remove(endTagIndex, endTagLen); // Remove endTag
                index -= (startTagLen + endTagLen); // Update index after removing startTag and endTag
            }
            else
            {
                index = startTagIndex;
            }
        }

        return sb.ToString();
    }


    static int IndexOf(StringBuilder sb, string substring, int startIndex=0)
    {
        // Method to return index of first occurance of substring in StringBuilder sb
        // Search start from startIndex

        for(int i = startIndex; i < sb.Length; i++)
        {
            if(sb[i] == substring[0])
            {
                for(int j = 0, k = i; j < substring.Length && k < sb.Length; j++, k++)
                {
                    if(j == substring.Length-1 && substring[j] == sb[k])
                    {
                        return i;
                    }
                    else if(substring[j] != sb[k])
                    {
                        i = k;
                        break;
                    }
                }
            }
        }

        return -1;
    }


    static string Substring(StringBuilder givenSb, int startIndex, int length)
    {
        // Method to return substring of given length starting from startIndex
        // in given StringBuilder instance sb

        StringBuilder sb = new();

        for(int i = startIndex; i < startIndex + length; i++)
        {
            sb.Append(givenSb[i]);
        }

        return sb.ToString();
    }
}