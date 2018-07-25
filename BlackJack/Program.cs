/*  Program Description:
 *  Program that mimics the card game of "BlackJack" otherwise know as 21
 *  
 *  File: BlackJack
 *  Date: 07/ April 2018
 *  
 *  01. Create class "SettingsConsoleStartup". As the program starts up set the console
 *  02. Ask Player do they want to play. If they do want to play ask them to enter their name 
 *  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        // shared amoungst all instance of a class
        static ConsoleKeyInfo keyInfoWantToPlay;       

        static void Main(string[] args)
        {
            List<CardDetails> DeckOfCards = new List<CardDetails>();
            bool playerWantsToPlay = true;
            bool playerHints = false;
            //bool playerBust = false, playerStick = false;
            string playerName = "";
            ConsoleKeyInfo keyInfoHints;
            int score = 0;
            //int playerScore = 0, cardCount = 0, dealerScore = 0; ;

            // Sets the Console display
            SettingsConsoleStartup.TitleBox();

            // interacts with play on wanting to play BlackJack
            Console.WriteLine("\t     Want a game of Blackjack - Y/ N? ");
            keyInfoWantToPlay = Console.ReadKey();

            // asks for player Name and if they want hints and tips
            if (keyInfoWantToPlay.Key == ConsoleKey.Y)
            {
                Console.Write("\n\t     Please enter your name >> ");
                playerName = Console.ReadLine();
                Players player = new Players(playerName);                

                Console.Write("\n\t     Would you like Tips >> Y/ N? ");
                keyInfoHints = Console.ReadKey();
                if(keyInfoHints.Key == ConsoleKey.Y)
                {
                    playerHints = true;
                }
                Console.WriteLine("\n");
            }


            // actions to be taken if the player wants to play BlackJack
            if (keyInfoWantToPlay.Key == ConsoleKey.Y)
            {
                do
                {                    
                    string[] card = new string[52];
                    int[] cardValue = new int[52];
                    

                    if (playerHints == true)
                    {
                        HintsAndTips.Hint(score);
                    }
                    
                    PackOfCardsShuffled packetOfCards = new PackOfCardsShuffled();

                    // creates a deck of cards
                    List<CardDetails> cards = packetOfCards.CreateDeck(DeckOfCards).ToList();
                    // shuffle the deck of cards
                    List<CardDetails> shuffledCards = packetOfCards.ShuffledCards(cards);

                    Console.WriteLine(shuffledCards);






                    // Resets the Console display
                    SettingsConsoleStartup.TitleBox();
                    Console.WriteLine("\n\t     {0}'s turn:", playerName);



                    Console.WriteLine("HAHAHA");
                    

                    Console.WriteLine("\n\t     Do you want to play again - Y/ N? ");
                    keyInfoWantToPlay = Console.ReadKey();

                    if (keyInfoWantToPlay.Key == ConsoleKey.N)
                    {
                        playerWantsToPlay = false;
                    }

                    } while (playerWantsToPlay == true); // end of do statement
            }


            // Ends the game in 3 seconds or if N is pressed
            if (playerWantsToPlay == false)
            {

                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine();
                    Console.Write("\tGame will exit in >> {0} << seconds. Goodbye!\r", i);
                    Pause second = new Pause(1);
                }
            }

        }// end of main()

    }// end of program class

}// end of namespace
