/*
 * File Name:           FormGame.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      4.7
 * Description:         Contains the base program code for the game of blackjack as 
 *                      well as all button events and variables from that.
 *                      This is the main code for the game and most methods are called from here
 *                      or called by the methods that were called here.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//uses the cards program namespace.
using Cards;
using System.Diagnostics;
using System.Media;

namespace Blackjack //part of the blackjack namespace
{
    //standard generation of the form class
	public partial class FormGame : Form
    {
        //setting the amount of starting cash the player has. 
        //Uses the default currency of the language and timezone settings that windows uses.
		private decimal bankroll = 1000.0M;
        //variable to store the amount of wins
        private int wins = 0;
        //variable to store the amount of ties
        private int ties = 0;
        //variable to store the amount of losses
        private int losses = 0;
        //declares a null deck of cards
		private Deck deck = null;
        //declares a dealer hand
		private DealerBlackjackHand dealerHand = null;
        //declares an array of hand panels for the player
		private BlackjackHandPanel[] playerPanels = null;
        //declares an array list of player hands
        private List<PlayerBlackjackHand> playerHands;
        //variable for the index of the current hand in play. (used for splitting)
        private int handInPlay;
        //declares soundtrack variable (unimplemented due to not having a file for it)
        //private SoundPlayer gameSound;

        //initialises the form sets default colour for config boxes,
        //populates array list for panels, initialises hand index and creates player hands
		public FormGame()
        {
			InitializeComponent();
			bankGroupBox.BackColor = configurationGroupBox.BackColor = Color.FromArgb(128, bankGroupBox.BackColor);
		    playerHands = new List<PlayerBlackjackHand>();
			playerPanels = new[] { playerHandPanel1, playerHandPanel2, playerHandPanel3, playerHandPanel4 };
            handInPlay = 0;

            //! add game sound later!
            // gameSound = new SoundPlayer(@"..\..\Resources\soundtrack.wav");
            // gameSound.Play();
		}
        //starts the game
		private void FormGameLoad(object sender, EventArgs e)
        {
			// Start game:
			resultsLabel.Text = "";
			StartGame();
		}
        //enables the config boxes and displays the bankroll
		private void StartGame()
        {
			configurationGroupBox.Enabled = true;
			bankGroupBox.Enabled = true;
			bankrollTextBox.Text = bankroll.ToString("c0");
		}
        //deals cards
		private void DealButtonClick(object sender, EventArgs e)
        {
            //checks if unnatural splits is enabled
			PlayerBlackjackHand.AllowUnnaturalSplits = allowUnnaturalSplitsCheckBox.Checked;
            //creates a new blackjack shoe containing the number of decks specified.
			deck = new Shoe((int)deckNumericUpDown.Value);
            //calls method to shuffle the deck
			deck.PerfectShuffle();
            //declares dealer Hand
			dealerHand = new DealerBlackjackHand();
            //declares player hands
			playerHands = new List<PlayerBlackjackHand>();
            //declares player hand sending the bet amount to the constructor for storage.
			PlayerBlackjackHand hand = new PlayerBlackjackHand(betAmountNumericUpDown.Value);
            //adds the hand to the player hand
			playerHands.Add(hand);
            //ensures that the hand index is set to 0
			handInPlay = 0;
            //populates the staring hands of both player and dealer, 
            //first card dealt to dealer is facedown (reason for false parameter).
			hand.Hit(deck.Deal(true));
			dealerHand.Hit(deck.Deal(false));
			hand.Hit(deck.Deal(true));
			dealerHand.Hit(deck.Deal(true));

			// Shut down the dealing area for now, 
			//	until end of hand.
			bankGroupBox.Enabled = false;
			configurationGroupBox.Enabled = false;
			resultsLabel.Text = "";

			// Show hands.
			dealerHandPanel.Hand = dealerHand;
			SetPlayerHands();

			// Configure controls for the current hand:
			if (playerHands[handInPlay].IsBlackjack)
            {
				standButton.Enabled = true;
				standButton.PerformClick();
			}
            else
            {
				// Check for dealer blackjack
				if (dealerHand.IsBlackjack) handInPlay = 1;
				ConfigureControls(handInPlay);
			}
		}

		private void ConfigureControls(int handNum)
        {
			// If handNum > all player hands then it's the dealer's turn
			if (handNum < playerHands.Count)
            {
				PlayerBlackjackHand hand = playerHands[handNum];
				hitButton.Enabled = (!hand.IsStood && !hand.IsBusted && !hand.IsBlackjack);
				standButton.Enabled = true;
				splitButton.Enabled = (hand.IsSplittable && playerHands.Count < 4);
				doubleButton.Enabled = hand.IsDoubleable;
			} 
            else
            {
				// Disable the player controls
				hitButton.Enabled = standButton.Enabled = splitButton.Enabled = doubleButton.Enabled = false;

				// Expose dealer's hand
				dealerHand.Expose();

				// Dealer's turn
				bool dealerMustPlay = false;
                //checks if dealer must play by checking if all player hands have blackjack or have gone bust.
				foreach (PlayerBlackjackHand playerHand in playerHands)
                {
					if (!playerHand.IsBusted && !playerHand.IsBlackjack)
                    {
						dealerMustPlay = true;
						break;
					}
				}
                //dealer hits and gets faceup cards until his value is greater than 17
				if (dealerMustPlay)
                {
					while (dealerHand.DealerDraws)
                    {
						dealerHand.Hit(deck.Deal(true));
					}
				}

				// Calculate the results of the bet and
				//	reset for the next deal
				decimal betResult = 0.0M;
				foreach (PlayerBlackjackHand hand in playerHands)
                {
					betResult += dealerHand.BetResult(hand,
						blackjackPayoutNumericUpDown.Value);
				}

                if (betResult == 0)
                {
                    resultsLabel.Text = "You broke even";
                    ties += 1;
                    lblTies.Text = "Ties: " + ties;
                }
                else if (betResult < 0)
                {
                    resultsLabel.Text = "You lost " + (-betResult).ToString("c0") + " (ha ha)!";
                    losses += 1;
                    lblLosses.Text = "Losses: " + losses;
                }
                else
                {
                    resultsLabel.Text = "You won " + betResult.ToString("c0");
                    wins += 1;
                    lblWins.Text = "Wins: " + wins;
                }

				bankroll += betResult;
				StartGame();
			}

			 //Highlight hand in play, (useful for splitting to see which hand is active)
			for (int i = 0; i < 4; i++)
            {
				playerPanels[i].Highlight = (i == handNum && handNum < playerHands.Count);
			}
		}
        //checks each player panels hand to see if it has cards, 
        //if true, the hand is added to the panel, if false the panel hand is set to null.
		private void SetPlayerHands()
        {
			for (int i = 0; i < 4; i++)
            {
				playerPanels[i].Hand = (i < playerHands.Count ? playerHands[i] : null);
			}
		}
        //draws a card for the active hand and calls setPlayerHands method to updated the GUI
        //then checks if hand is blackjack, 21 0r bust and stands if true, else controls for play are enabled for that hand.
		private void HitButtonClick(object sender, EventArgs e)
        {
			playerHands[handInPlay].Hit(deck.Deal(true));
			SetPlayerHands();

            if (playerHands[handInPlay].IsBlackjack || playerHands[handInPlay].IsBusted || playerHands[handInPlay].Value == 21)
            {
                standButton.PerformClick();
            }
            else
            {
                ConfigureControls(handInPlay);
            }
		}
        //sets current hand to stand. increases the index for hand in play, sets player hands and configures controls
        //(disables or enables controls depending on whether there is still an active hand.
		private void StandButtonClick(object sender, EventArgs e)
        {
			playerHands[handInPlay].Stand();
			handInPlay++;
			SetPlayerHands();
			ConfigureControls(handInPlay);
		}
        //splits the hand by moving one card to another player hand and draws a new card for each hand
        //then checks if the active hand has a value of 21 and stands if it does.
        //else it configures controls (which checks for bust ect.)
		private void SplitButtonClick(object sender, EventArgs e)
        {
			PlayerBlackjackHand newHand = playerHands[handInPlay].Split(deck.Deal(true), deck.Deal(true));
			playerHands.Add(newHand);
			SetPlayerHands();

            if (playerHands[handInPlay].Value == 21)
            {
                standButton.PerformClick();
            }
            else
            {
                ConfigureControls(handInPlay);
            }
		}

        //sets hand to double and hits. play cannot continue for the current hand after doubling.
        //increments hand index, sets hands and configures controls.
		private void DoubleButtonClick(object sender, EventArgs e)
        {
			playerHands[handInPlay].Double(deck.Deal(true));
			handInPlay++;
			SetPlayerHands();
			ConfigureControls(handInPlay);
		}
        //closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}