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

        // Nested tags
        // string s = "<upcase>Wikipedia</upcase> has been praised for enabling the <upcase>democratization of knowledge,<upcase> its extensive coverage, unique structure, and culture. Wikipedia has been censored by some national governments,<upcase> ranging from specific</upcase> pages to the entire site.[7][8] Although Wikipedia's volunteer editors have written extensively on a wide variety of topics, the encyclopedia has been criticized for systemic bias, such</upcase> as a gender bias against women and geographical bias against the Global South (Eurocentrism).[9][10] While the reliability of Wikipedia was</upcase> frequently criticized in the 2000s, it has improved over time, receiving greater praise from the late 2010s onward,[4][11][12] while becoming an important fact-checking site</upcase>.[13][14] Articles on breaking news are often accessed as sources for up-to-date information about <upcase>those</upcase> events.";

        string s;

        Console.WriteLine("Program to UPPERCASE everything between given start tag " +
        "end tag in given string");

        while(true)
        {
            try
            {
                s = GetString("Enter string: ");

                Console.WriteLine();
                string startTag = GetString("Start tag: ");

                Console.WriteLine();
                string endTag = GetString("End tag: ");

                Console.WriteLine();
                Console.WriteLine("Given string:");
                Console.WriteLine(s);

                string result = ConvertToUpper(s, startTag, endTag);

                Console.WriteLine();
                Console.WriteLine("Formatted string:");
                Console.WriteLine(result);
                break;
            }
            catch(ApplicationException e)
            {
                Console.WriteLine();
                Console.WriteLine($"Error: {e.Message}");
            }
        }
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
        // Nested tags will cause problems

        // Throw Exception if uneven of nested tags are found in given string
        ValidateString(s, startTag, endTag);

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

                sb = MakeUppercase(sb, tempStartIndex, endTagIndex-1); // Changing every character to uppercase using char.ToUpperInvariant()
                // sb.Replace(Substring(sb, tempStartIndex, tempCount), Substring(sb, tempStartIndex, tempCount).ToUpperInvariant(), tempStartIndex, tempCount); // Replacing the substring between startTag and endTag with its UPPER variant

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


    static void ValidateString(string s, string startTag, string endTag)
    {
        // Throw error if nested tags or uneven no. of startTag and endTag are found
        //
        // Logic: Throw error if
        // 1. If no. of start tag is not equal to no. of end tag
        // 2. start tag is not followed up by end tag

        int len = s.Length;
        int startTagCount = 0;
        int endTagCount = 0;
        int index = 0;

        do
        {
            index = s.IndexOf(startTag, index);

            if(index >= 0)
            {
                startTagCount++;
                index++;
            }
        }
        while(index >= 0 && index < len);

        index = 0;
        do
        {
            index = s.IndexOf(endTag, index);

            if(index >= 0)
            {
                endTagCount++;
                index++;
            }
        }
        while(index >= 0 && index < len);

        if(startTagCount != endTagCount)
        {
            throw new ApplicationException($"No. of start tag {startTag} is not equal to no. of end tag {endTag}");
        }

        int indexOfStartTag, indexOfEndTag, tempStartIndex, tempEndIndex;
        tempStartIndex = tempEndIndex = -1;

        do
        {
            indexOfStartTag = s.IndexOf(startTag, tempStartIndex+1);
            indexOfEndTag = s.IndexOf(endTag, tempEndIndex+1);
            
            if(tempEndIndex > -1 && indexOfStartTag > -1 && (indexOfStartTag < tempEndIndex || indexOfStartTag > indexOfEndTag))
            {
                throw new ApplicationException("Nested tags not allowed");
            }
            else
            {
                tempStartIndex = indexOfStartTag;
                tempEndIndex = indexOfEndTag;
            }
        }
        while(indexOfStartTag > -1 && indexOfEndTag > -1 && tempStartIndex+1 < len && tempEndIndex+1 < len);
    }


    static StringBuilder MakeUppercase(StringBuilder sb, int startIndex, int endIndex)
    {
        // Method to uppercase every character from startIndex to endIndex 
        // in given StringBuilder object

        for(int i = startIndex; i <= endIndex && i < sb.Length; i++)
        {
            sb[i] = char.ToUpperInvariant(sb[i]);
        }

        return sb;
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