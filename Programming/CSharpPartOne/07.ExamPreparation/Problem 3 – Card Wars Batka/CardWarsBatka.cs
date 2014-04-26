using System;
using System.Numerics;

class CardWarsBatka
{
    static void Main()
    {
        checked
        {
            int gameNumbers = int.Parse(Console.ReadLine());

            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
            int[] points = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13 };            

            int inputsSize = gameNumbers * 6;
            string[] inputs = new string[inputsSize];

            for (int i = 0; i < inputsSize; i++)
            {
                inputs[i] = Console.ReadLine();
            }

            BigInteger firstPlayerScores = 0;
            BigInteger secondPlayerScores = 0;

            int gamesWonByFirstPlayer = 0;
            int gamesWonBySecondPlayer = 0;

            bool isFirstPlayerDrawX = false;
            bool isSecondPlayerDrawX = false;

            long firstHandStrength = 0;
            long secondHandStrength = 0;            

            int length = gameNumbers;
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                // first player
                string firstCardPlayerOne = inputs[i + index++];
                string secondCardPlayerOne = inputs[i + index++];
                string thirdCardPlayerOne = inputs[i + index++];

                for (int j = 0; j < cards.Length; j++)
                {
                    if (cards[j] == firstCardPlayerOne)
                    {
                        firstHandStrength += points[j];
                    }

                    if (cards[j] == secondCardPlayerOne)
                    {
                        firstHandStrength += points[j];
                    }

                    if (cards[j] == thirdCardPlayerOne)
                    {
                        firstHandStrength += points[j];
                    }
                }

                // second player
                string firstCardPlayerTwo = inputs[i + index++];
                string secondCardPlayerTwo = inputs[i + index++];
                string thirdCardPlayerTwo = inputs[i + index];

                for (int j = 0; j < cards.Length; j++)
                {
                    if (cards[j] == firstCardPlayerTwo)
                    {
                        secondHandStrength += points[j];
                    }

                    if (cards[j] == secondCardPlayerTwo)
                    {
                        secondHandStrength += points[j];
                    }

                    if (cards[j] == thirdCardPlayerTwo)
                    {
                        secondHandStrength += points[j];
                    }
                }

                // check players' hand strengths 
                if (firstHandStrength > secondHandStrength)
                {
                    gamesWonByFirstPlayer++;
                    firstPlayerScores += firstHandStrength;
                }
                else if (secondHandStrength > firstHandStrength)
                {
                    gamesWonBySecondPlayer++;
                    secondPlayerScores += secondHandStrength;
                }

                // checks first player cards for special ones
                for (int s = i * 6; s < (i * 6) + 3; s++)
                {
                    if (inputs[s] == "Z")
                    {
                        firstPlayerScores *= 2;
                    }

                    if (inputs[s] == "Y")
                    {
                        firstPlayerScores -= 200;
                    }

                    if (inputs[s] == "X")
                    {
                        isFirstPlayerDrawX = true;
                    }
                }

                // checks second player cards for special ones
                for (int s = (i * 6) + 3; s < (i * 6) + 6; s++)
                {
                    if (inputs[s] == "Z")
                    {
                        secondPlayerScores *= 2;
                    }

                    if (inputs[s] == "Y")
                    {
                        secondPlayerScores -= 200;
                    }

                    if (inputs[s] == "X")
                    {
                        isSecondPlayerDrawX = true;
                    }
                }

                // if both players draw "X" card
                if (isFirstPlayerDrawX == true && isSecondPlayerDrawX == true)
                {
                    firstPlayerScores += 50;
                    isFirstPlayerDrawX = false;

                    secondPlayerScores += 50;
                    isSecondPlayerDrawX = false;
                }

                firstHandStrength = 0;
                secondHandStrength = 0;
            }

            if (isFirstPlayerDrawX == true || isSecondPlayerDrawX == true)
            {
                if (isFirstPlayerDrawX == true)
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                }
                else if (isSecondPlayerDrawX == true)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                }
            }
            else
            {
                if (firstPlayerScores > secondPlayerScores)
                {
                    Console.WriteLine("First player wins!");
                    Console.WriteLine("Score: {0}", firstPlayerScores);
                    Console.WriteLine("Games won: {0}", gamesWonByFirstPlayer);
                }
                else if (secondPlayerScores > firstPlayerScores)
                {
                    Console.WriteLine("Second player wins!");
                    Console.WriteLine("Score: {0}", secondPlayerScores);
                    Console.WriteLine("Games won: {0}", gamesWonBySecondPlayer);
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    Console.WriteLine("Score: {0}", firstPlayerScores);
                }
            }
        }
    }
}
