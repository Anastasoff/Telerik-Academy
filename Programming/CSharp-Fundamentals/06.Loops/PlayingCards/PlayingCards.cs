using System;

// 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
// The cards should be printed with their English names. Use nested for loops and switch-case.
class PlayingCards
{
    static void Main()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] cards = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        foreach (string suit in suits)
        {
            foreach (string card in cards)
            {
                Console.WriteLine("{0} of {1}", suit, card);
            }

            Console.WriteLine(new string('=', 15));
        }
    }
}
