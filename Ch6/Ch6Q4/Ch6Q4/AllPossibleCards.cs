// Write a program that prints all possible cards from a standard deck 
// of cards, without jokers (there are 52 cards: 4 suits of 13 cards). 

class AllPossibleCards
{
    static void Main()
    {
        Console.WriteLine("Program to print all possible cards from " +
        "a deck of cards without jokers.");

        for(int card = 1; card <= 13; card++)
        {
            for(int suit = 1; suit <= 4; suit++)
            {
                string sCard = "", sSuit = "";
                switch(card)
                {
                    case 1:
                        {
                            sCard = "Ace";
                            break;
                        }
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        {
                            sCard = card.ToString();
                            break;
                        }
                    case 11:
                        {
                            sCard = "Jack";
                            break;
                        }
                    case 12:
                        {
                            sCard = "Queen";
                            break;
                        }
                    case 13:
                        {
                            sCard = "King";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }

                switch(suit)
                {
                    case 1:
                        {
                            sSuit = "Clubs";
                            break;
                        }
                    case 2:
                        {
                            sSuit = "Diamonds";
                            break;
                        }
                    case 3:
                        {
                            sSuit = "Hearts";
                            break;
                        }
                    case 4:
                        {
                            sSuit = "Spades";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }

                Console.WriteLine($"{sCard} of {sSuit}");
            }
        }
    }
}