/*  Program Description:
 *  Program that mimics the card game of "BlackJack" otherwise know as 21
 *  
 *  File: BlackJack
 *  Date: 26/ July 2018
 *  
 *  The github version was orginally a console application. I didn't like the UI, hence
 *  convert the application over to a Windows Form Application to have a nicer UI.
 *  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class UI_BlackJack : Form
    {
        // 52 card deck used to play a game of BlackJack
        public List<Card> Deck = new List<Card>();
        // used as a twister counter to update pictureBox after selecting btnTwist
        int twistCounter = 3;
        int dealerCounter = 3;
        // records the players score as the game progress
        int playerScore = 0;
        int dealerScore = 0;

        public UI_BlackJack()
        {
            InitializeComponent();
            btnStick.Enabled = false;
            btnTwist.Enabled = false;
            lbPlayerScore.Enabled = false;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // player select the deal button and deals two cards.
        private void BtnDeal_Click(object sender, EventArgs e)
        {
            btnStick.Enabled = true;
            btnTwist.Enabled = true;
            lbPlayerScore.Enabled = true;

            try
            {
                PackOfCardsShuffled deckOfPlayingCards = new PackOfCardsShuffled();

                deckOfPlayingCards.CreateDeck(Deck);

                // deals out the initial two cards
                pbxCard1.Image = Deck[0].Picture;
                pbxCard1.SizeMode = PictureBoxSizeMode.CenterImage;
                pbxCard2.Image = Deck[1].Picture;
                pbxCard2.SizeMode = PictureBoxSizeMode.CenterImage;

                playerScore = Deck[0].CardValueNum + Deck[1].CardValueNum;

                // modifies the deck of card so that the same cards can be played again. Until a new deck has been created.
                Deck.Remove(Deck[0]);
                Deck.Remove(Deck[0]);

                // Lets the player know what their initial score is. 
                lbPlayerScoreTotal.Text = Convert.ToString(playerScore);

                btnDeal.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        // player select's the twist btn to get another card from the deck
        private void BtnTwist_Click(object sender, EventArgs e)
        {

            if (pbxCard3.Image == null && twistCounter == 3)
            {
                pbxCard3.Image = Deck[0].Picture;
                pbxCard3.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }
            else if (pbxCard4.Image == null && twistCounter == 4)
            {
                pbxCard4.Image = Deck[0].Picture;
                pbxCard4.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }
            else if (pbxCard5.Image == null && twistCounter == 5)
            {
                pbxCard5.Image = Deck[0].Picture;
                pbxCard5.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }
            else if (pbxCard6.Image == null && twistCounter == 6)
            {
                pbxCard6.Image = Deck[0].Picture;
                pbxCard6.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }
            else if (pbxCard7.Image == null && twistCounter == 7)
            {
                pbxCard7.Image = Deck[0].Picture;
                pbxCard7.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }
            else if (pbxCard8.Image == null && twistCounter == 8)
            {
                pbxCard8.Image = Deck[0].Picture;
                pbxCard8.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }
            else if (pbxCard9.Image == null && twistCounter == 9)
            {
                pbxCard9.Image = Deck[0].Picture;
                pbxCard9.SizeMode = PictureBoxSizeMode.CenterImage;
                playerScore = Deck[0].CardValueNum + playerScore;
                Deck.Remove(Deck[0]);
            }

            // Lets the player know what their initial score is. 
            lbPlayerScoreTotal.Text = Convert.ToString(playerScore);

            twistCounter++;
        }

        private void BtnStick_Click(object sender, EventArgs e)
        {
            btnTwist.Enabled = false;

            // deals out the initial two cards
            pbxCard10.Image = Deck[0].Picture;
            pbxCard10.SizeMode = PictureBoxSizeMode.CenterImage;

            //Pause second = new Pause(1);

            pbxCard11.Image = Deck[1].Picture;
            pbxCard11.SizeMode = PictureBoxSizeMode.CenterImage;

            //second = new Pause(1);

            dealerScore = Deck[0].CardValueNum + Deck[1].CardValueNum;

            // modifies the deck of card so that the same cards can be played again. Until a new deck has been created.
            Deck.Remove(Deck[0]);
            Deck.Remove(Deck[0]);

            // Lets the player know what their initial score is. 
            lbDealerScoreTotal.Text = Convert.ToString(dealerScore);
            
            DealersDeal();
        }


        private void DealersDeal()
        {
            if (pbxCard12.Image == null && dealerCounter == 3)
            {
                pbxCard12.Image = Deck[0].Picture;
                pbxCard12.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;
            }
            if (pbxCard13.Image == null && dealerCounter == 4)
            {
                pbxCard13.Image = Deck[0].Picture;
                pbxCard13.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;
            }
            if (pbxCard14.Image == null && dealerCounter == 5)
            {
                pbxCard14.Image = Deck[0].Picture;
                pbxCard14.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;
            }
            if (pbxCard15.Image == null && dealerCounter == 6)
            {
                pbxCard15.Image = Deck[0].Picture;
                pbxCard15.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;
            }
            if (pbxCard16.Image == null && dealerCounter == 7)
            {
                pbxCard16.Image = Deck[0].Picture;
                pbxCard16.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;
            }
            if (pbxCard17.Image == null && dealerCounter == 8)
            {
                pbxCard17.Image = Deck[0].Picture;
                pbxCard17.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;
            }
            if (pbxCard18.Image == null && dealerCounter == 9)
            {
                pbxCard18.Image = Deck[0].Picture;
                pbxCard18.SizeMode = PictureBoxSizeMode.CenterImage;
                dealerScore = Deck[0].CardValueNum + dealerScore;
                Deck.Remove(Deck[0]);
                dealerCounter++;                
            }

            // Lets the player know what their initial score is. 
            lbDealerScoreTotal.Text = Convert.ToString(dealerScore);            
        }
    }
}
