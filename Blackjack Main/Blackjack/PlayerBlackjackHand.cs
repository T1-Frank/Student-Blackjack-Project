/*
 * File Name:           PlayerBlackjackHand.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      3.2
 * Description:         Player's blackjack hand.  The basic BlackjackHand functionality is 
	                    enhanced with player-specific features.  Because of splits, there may
	                    be several player hands at any given time.
 */
using System;
using System.Collections.Generic;
using System.Text;
//using the cards namespace
using Cards;

namespace Blackjack //part of the Blackjack namespace
{
	public class PlayerBlackjackHand : BlackjackHand
    {
		private decimal bet = 0.0M;
		private bool isStood = false;
        
		// Creates a player blackjack hand.
		public PlayerBlackjackHand(decimal bet, params Card[] cards)
			: base(cards)
        {
			this.bet = bet;
		}
        
		// Indicates the bet on this hand.
		public decimal Bet
        {
			get
            { 
                return bet; 
            }
		}
        
		// Indicates whether the hand can be doubled.
		public bool IsDoubleable
        {
			get
            { 
                return (!IsStood && Count == 2); 
            }
		}
        
		// Indicates whether the hand can be split.
		// "Unnatural splits" allows any two cards to be split.
		public bool IsSplittable
        {
			get
            {
                if (AllowUnnaturalSplits)
                {
                    return (Count == 2);
                }

				return (Count == 2 && cards[0].Rank == cards[1].Rank);
			}
		}
        
		// Indicates whether the hand has been stood.
		public bool IsStood
        {
			get
            { 
                return isStood; 
            }
		}
        
		// Stands (stops playing) the hand.
		public void Stand()
        {
			isStood = true;
			FireChangedEvent();
		}
        
		// Splits the hand into two hands, both of which 
		// are played independently.
		public PlayerBlackjackHand Split(Card c1, Card c2)
        {
			Card startOfNewHand = cards[1];
			cards.RemoveAt(1);
			cards.Add(c1);
			FireChangedEvent();
			return new PlayerBlackjackHand(bet, startOfNewHand, c2);
		}
        
		// Accepts one card, then stands, doubling the bet.
		public void Double(Card c)
        {
			bet *= 2;
			cards.Add(c);
			Stand();
		}
        
		// Allows testing of the split code by making any two cards splitable
		// (they no longer need to be a pair).
		static public bool AllowUnnaturalSplits
        { 
            get; set; 
        }
	}
}
