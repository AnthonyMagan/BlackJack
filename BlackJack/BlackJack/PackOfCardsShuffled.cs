using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public class PackOfCardsShuffled
    {
        public const string imagePath = @"Cards/";
        
        // Create Deck Method to create new deck in order.
        public List<Card> CreateDeck(List<Card> DeckOfCards)
        {

            string[] cards = { "Two of clubs", "Three of clubs", "Four of clubs", "Five of clubs", "Six of clubs", "Seven of clubs", "Eight of clubs", "Nine of clubs", "Ten of clubs", "Jack of clubs", "Queen of clubs", "King of clubs", "Ace of clubs",
                                "Two of spades", "Three of spades", "Four of spades", "Five of spades", "Six of spades", "Seven of spades", "Eight of spades", "Nine of spades", "Ten of spades", "Jack of spades", "Queen of spades", "King of spades", "Ace of spades",
                                "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Hearts",
                                "Two of diamonds", "Three of diamonds", "Four of diamonds", "Five of diamonds", "Six of diamonds", "Seven of diamonds", "Eight of diamonds", "Nine of diamonds", "Ten of diamonds", "Jack of diamonds", "Queen of diamonds", "King of diamonds", "Ace of diamonds"};            
            int[] value = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
                            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
                            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11,
                            2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11};

            for (int i = 0; i < 51; i++)
            {
                DeckOfCards.Add(new Card { CardValueText = cards[i], CardValueNum = value[i], Picture = Image.FromFile(imagePath + i + ".jpg") });
            }

            ShuffleDeck(DeckOfCards);

            return DeckOfCards;
        }


        //ShuffleDeck Method
        //public static void ShuffleDeck(ref string[] card, ref int[] cardValue)
        private static void ShuffleDeck(List<Card> DeckOfCards)
        {
            bool twoAces = true;

            do
            {
                Random rnd = new Random();

                // shuffles the cards 1000 times to ensure a good shuffle.
                for (int i = 0; i < 1000; i++)
                {
                    int firstCard = rnd.Next(0, 51);
                    int secondCard = rnd.Next(0, 51);

                    if (firstCard != secondCard)
                    {
                        Card temp = DeckOfCards[firstCard];
                        DeckOfCards[firstCard] = DeckOfCards[secondCard];
                        DeckOfCards[secondCard] = temp;
                    }
                }

                // stops looping the shuffle if the first 2 cards are 2 aces
                if (DeckOfCards[0].CardValueNum != 11 || DeckOfCards[1].CardValueNum != 11)
                    twoAces = false;
            }
            while (twoAces);//loops if first 2 cards are both aces

        }// end of Shuffle Method


        private void ResetShuffledDeck(List<Card> DeckOfCards)
        {
            foreach (var card in DeckOfCards)
            {
                card.Picture.Dispose();
            }
        }
    }
}
