/*
 * File Name:           DealerBlackjackHand.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.1
 * Description:         Dealer's blackjack hand.  The basic BlackjackHand functionality is enhanced with 
 *                      aspects specific to the dealer.
 */
using System;
using System.Collections.Generic;
using System.Text;
//uses the cards program
using Cards;

namespace Blackjack //part of the blackjack namespace
{
    //inherits from BlackjackHand
    public class DealerBlackjackHand : BlackjackHand
    {
        //constructor for DealerBlackjackHand
        public DealerBlackjackHand(params Card[] _cards)
            : base(_cards)
        {
        }

        //method to determine if the dealer draws as the dealer must draw until they have a value above 17.
        public bool DealerDraws
        {
            get
            { 
                return (Value < 17); 
            }
        }

        //overide of hit method from BlackjackHand class as the dealer has 
        //to hit until they are above 17 and cant hit after passing 17.
        public override void Hit(Card c)
        {
            if (!DealerDraws)
            {
                throw new Exception("Dealer is drawing with too high a hand value!");
            }

            base.Hit(c);
        }

        // Returns the amount won or lost based on the dealer's
        // hand.  Returns 0.0M for "push" (tie).
        // This method is called for each player hand in the case of splits. 
        //and is doubled on the calling procedures side if the double button was used.
        public decimal BetResult(PlayerBlackjackHand playerHand, decimal blackjackPayout)
        {
            if (this.IsBlackjack && playerHand.IsBlackjack)
            {
                return 0.0M;
            }

            if (this.IsBlackjack)
            {
                return -playerHand.Bet;
            }

            if (playerHand.IsBlackjack)
            {
                return playerHand.Bet * blackjackPayout;
            }

            if (playerHand.IsBusted)
            {
                return -playerHand.Bet;
            }

            if (this.IsBusted)
            {
                return playerHand.Bet;
            }

            if (this.Value == playerHand.Value)
            {
                return 0.0M;
            }

            if (this.Value < playerHand.Value)
            {
                return playerHand.Bet;
            }

            return -playerHand.Bet;
        }
    }
}
