// Write a program, which generates a random advertising message for 
// some product. The message has to consist of laudatory phrase, followed 
// by a laudatory story, followed by author (first and last name) and city, 
// which are selected from predefined lists. For example, let’s have the 
// following lists: 
// - Laudatory phrases: {"The product is excellent.", "This is a great 
// product.", "I use this product constantly.", "This is the best product 
// from this category."}. 
// - Laudatory stories: {"Now I feel better.", "I managed to change.", 
// "It made some miracle.", "I can’t believe it, but now I am feeling 
// great.", "You should try it, too. I am very satisfied."}. 
// - First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}. 
// - Last name of the author: {"Johnson", "Peterson", "Charls"}. 
// - Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}. 
//
// Then the program would print randomly generated advertising message 
// like the following:  
// I use this product constantly. You should try it, too. I am 
// very satisfied. -- Hellen Peterson, Berlin 

using System.Text;

class FakeAds
{
    static Random Rng = new Random();

    static void Main()
    {
        while(true)
        {
            Console.WriteLine(GenerateFakeAds());
            Console.ReadLine();
        }
    }


    static string GenerateFakeAds()
    {
        // Method to generate Fake Ads

        string[] phrases = {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
        string[] stories = {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can't believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
        string[] authorFirstName = {"Dayan", "Stella", "Hellen", "Kate"};
        string[] authorLastName = {"Johnson", "Peterson", "Charls"};
        string[] cities = {"London", "Paris", "Berlin", "New York", "Madrid"};

        StringBuilder sb = new StringBuilder();

        AppendRandomElementFrom(phrases, sb);
        AppendRandomElementFrom(stories, sb);
        AppendRandomElementFrom(authorFirstName, sb, " -- ");
        AppendRandomElementFrom(authorLastName, sb, ", ");
        AppendRandomElementFrom(cities, sb);

        return sb.Remove(0, 1).ToString();
    }


    static void AppendRandomElementFrom(string[] array, StringBuilder sb, string extra=" ")
    {
        // Method to append any random element form given array to 
        // StringBuilder object sb

        sb.Append(extra);
        sb.Append(array[Rng.Next(array.Length)]);
    }
}