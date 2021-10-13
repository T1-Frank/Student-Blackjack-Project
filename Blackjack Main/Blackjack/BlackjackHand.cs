/*
 * File Name:           BlackjackHand.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.3
 * Description:         Contains the minimum functionality and required features of a blackjack hand, 
 *                      either for the player or the dealer.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
//using the cards program (used for deck creation and management)
using Cards;

namespace Blackjack //part of the Blackjack namespace
{
    //defines the BlackjackHand class as abstract and inherits from the PileOfCards class
    //from the Cards namespace
    public abstract class BlackjackHand : PileOfCards
    {
        //declares the event named change which is triggered everytime a hand of cards is altered
        public event EventHandler Changed;

        //constructor for the BlackjackHand class, used as reference for the inheriting class
        public BlackjackHand(params Card[] cards)
            : base(cards)
        {
        }

        // Expose all cards in this hand. Used to reveal any cards that are face down.
        public void Expose()
        {
            foreach (Card c in cards) c.FaceUp = true;
            FireChangedEvent(); //calls method to trigger the changed event.
        }

        // Add a card to the hand.
        public virtual void Hit(Card c)
        {
            cards.Add(c);
            FireChangedEvent(); //calls method to trigger the changed event.
        }

        // Get value (closest to 21 that can be made).
        public int Value
        {
            get
            {
                int value = 0, aces = 0;
                foreach (Card c in this)
                {
                    if (c.Rank == Ranks.Ace)
                    {
                        value += 1;
                        aces++;
                    }
                    else if (c.Rank < Ranks.Ten)
                        value += (int)c.Rank;
                    else
                        value += 10;
                }

                while (value <= 11 && aces > 0)
                {
                    // Count one ace high instead of low:
                    value += 10;
                    aces--;
                }
                return value;
            }
        }

        // Get the smallest possible value (aces count as 1s)
        public int MinValue
        {
            get
            {
                int value = 0;
                foreach (Card c in this)
                {
                    if (c.Rank < Ranks.Ten)
                        value += (int)c.Rank;
                    else
                        value += 10;
                }
                return value;
            }
        }
        // Returns true if at least one ace can be counted "high".
        public bool IsSoft
        {
            get
            { 
                return MinValue != Value; 
            }
        }

        // Returns true if the hand is bust.
        public bool IsBusted
        {
            get
            { 
                return (Value > 21); 
            }
        }

        // Returns true if the hand is a blackjack.

        public bool IsBlackjack
        {
            get
            {
                return (Count == 2 && Value == 21);
            }
        }

        // Returns the hand as a string of card names.
        public override string ToString()
        {
            string results = "";
            foreach (Card c in cards)
            {
                results += c.ToString() + " ";
            }
            return results;
        }

        protected void FireChangedEvent()
        {
            if (Changed != null) Changed(this, EventArgs.Empty);
        }
    }
}
