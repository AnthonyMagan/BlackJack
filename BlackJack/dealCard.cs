using System;

namespace BlackJack
{
    public class dealCard
    {
        public static bool DealNextCard(bool playerStick, int playerScore, int[] cardValue, int cardCount, string[] card, bool playerHints, int dealerScore)
        {
            Pause pause = new Pause(1);
            bool hints = playerHints;

            if (!playerStick)//will deal card and add to player's score if he hasn't stuck, otherwise it's the dealers turn
            {
                playerScore += cardValue[cardCount];
                Console.WriteLine("\n\tCard dealt is {0},   value {1}", card[cardCount], cardValue[cardCount]);
                Console.WriteLine("\tTOTAL = {0}", playerScore);
                cardCount++;

                if (hints && playerScore <= 21 && cardCount > 1)//display hint if hints turned on, only from 2nd card on
                    Console.WriteLine(HintsAndTips.Hint(playerScore));

                if (playerScore > 21)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\tBUST!!! BUST!!! BUST!!!");
                    return true;
                }
            }
            //dealer gets card and added to dealers total
            else
            {
                dealerScore += cardValue[cardCount];
                Console.WriteLine("\n\tCard dealt is {0},   value {1}", card[cardCount], cardValue[cardCount]);
                Console.WriteLine("\tTOTAL = {0}", dealerScore);
                cardCount++;
                if (dealerScore > 21)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\tBUST!!! BUST!!! BUST!!!");
                    return true;
                }
            }
            return false;
        }
    }
}
