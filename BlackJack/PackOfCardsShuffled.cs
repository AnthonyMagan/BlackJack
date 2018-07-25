using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class PackOfCardsShuffled
    {
        //CreateDeck Method to create new deck of cards with corresponding values
        public List<CardDetails> CreateDeck(List<CardDetails> DeckOfCards)
        {
            string[] cards = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };
            int[] value = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

            for (int i = 0; i < suits.Length; i++)//loop for each suit
            {
                for (int j = 0; j < cards.Length; j++)//loop for each card type/value
                {
                    DeckOfCards.Add(new CardDetails { CardValueText = cards[j], Suit = suits[i], CardValueNum = value[j] });
                }
            }

            return DeckOfCards;
        }

        public List<CardDetails> ShuffledCards(List<CardDetails> DeckOfCards)
        {
            List<CardDetails> cardsToBeshuffled = new List<CardDetails>();
            List<CardDetails> shuffledCards = new List<CardDetails>();
            Random rand = new Random();
            int rndIndex1 = rand.Next(0, DeckOfCards.Count);
            int rndIndex2 = rand.Next(0, DeckOfCards.Count);            
            // PROBLEM: If the player gets dealt 2 aces initially then game goes bust
            // with a score of 22. This would represent a reshuffle without a penality
            // to the player. 
            // Hence if two aces come up initially the game reshuffles without penality
            // to the player.
            bool twoAces = true;

            // iterates through the deck of cards
            foreach (var card in DeckOfCards)
            {
                cardsToBeshuffled.Add(new CardDetails { CardValueText = card.CardValueText, Suit = card.Suit, CardValueNum = card.CardValueNum });
            }

            // removes two random indexes from the List<CardDetails> cardsToBeshuffled
            if (rndIndex1 != rndIndex2)
            {
                cardsToBeshuffled.RemoveAt(rndIndex1);
                cardsToBeshuffled.RemoveAt(rndIndex2);
            }

            do
            {
                //var array = new CardDetails[cardsToBeshuffled.Count];

                for (int i = 0; i < cardsToBeshuffled.Count; i++)
                {
                    int rndShuffler = rand.Next(0, cardsToBeshuffled.Count);

                    Console.WriteLine($"{shuffledCards}");
                    //if (shuffledCards == null)
                    //{
                    //    shuffledCards[rndShuffler] = card;
                    //}
                    //if (array[rndShuffler] == null)
                    //{
                    //    array[rndShuffler] = card;
                    //}
                }

            } while (twoAces); //loops if first 2 cards are both aces

            return shuffledCards;
        }

    }
}
