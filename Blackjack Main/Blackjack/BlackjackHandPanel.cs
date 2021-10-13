/*
 * File Name:           BlackjackHandPanel.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.6
 * Description:         Contains functionality to display the hand, message and value of the hand
 *                       in an object which can be altered procedurally
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
//using the cards program (used for deck creation and management).
using Cards;

namespace Blackjack //part of the Blackjack namespace.
{
    //inherits from the card panel class.
	public partial class BlackjackHandPanel : CardPanel
    {
        //used to initialise the component.
		public BlackjackHandPanel()
        {
			InitializeComponent();
		}

		[Browsable(false)] //removes this property from the properties window.
        //get and set methods for BlackjackHand. sets the changed event handler and calls the refresh method
		public BlackjackHand Hand {
			get
            {
                return (Cards as BlackjackHand);
            }
			set
            {
				if (Cards != null && Cards is BlackjackHand) (Cards as BlackjackHand).Changed -= hand_Changed;
				Cards = value;
				if (Cards != null) (Cards as BlackjackHand).Changed += hand_Changed;
				Refresh();
			}
		}
        //hand changed event handler. calls the refresh method.
		void hand_Changed(object sender, EventArgs e) {
			Refresh();
		}
        //override of refresh method, calls the update status method.
		public override void Refresh() {
			this.Invalidate();
			UpdateStatus();
		}
        //update status method, changes message and message colour based on the hand.
        //displays player hand value.
		private void UpdateStatus() {
            //checks if hand is null (no game started, hand is empty)
			if (Hand != null)
            {
                //checks if current hand has blackjack (2 cards that have a value of 21)
				if (Hand.IsBlackjack) {
                    //changes message colour to blue and displays message.
					ForeColor = Color.Blue;
					Text = "Blackjack!";
				}
                //checks if current hand is bust.
                else if (Hand.IsBusted) {
                    //changes message colour and displays message.
					ForeColor = Color.Yellow;
					Text = "Bust!";
				}
                //if hand is not bust or blackjack this code block is run.
                else
                {
                    int value = 0; //local storage variable for hand value
                    value = this.Hand.Value; //setting value to be equal to the value of this hand. (calls method to check).
                    //if it is the players hand thent he value is displayed
                    if (this.Hand is PlayerBlackjackHand)
                    {
                        ForeColor = Color.Yellow;
                        Text = value.ToString();
                    }
                    //if it is not player hand then it must be the dealers hand.
                    //since one card is facedown no value is displayed.
                    else
                    {
                        ForeColor = Color.Yellow;
                        Text = "";
                    }
                }
					
			}
            //if hand is null set message to be blank.
            else {
				Text = "";
			}
		}
	}
}
