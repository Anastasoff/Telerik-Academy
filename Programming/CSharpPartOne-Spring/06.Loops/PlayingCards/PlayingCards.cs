/* 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
 * The cards should be printed with their English names. Use nested for loops and switch-case.
*/

using System;

class PlayingCards
{
    static void Main()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] cards = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} of {1}", suits[i], cards[j]);
            }
            Console.WriteLine("-*-*-*-*-*-*-*-");
        }

        //foreach (string suit in suits)
        //{
        //    foreach (string card in cards)
        //    {
        //        Console.WriteLine("{0} of {1}", suit, card);
        //    }
        //}
    }
}
