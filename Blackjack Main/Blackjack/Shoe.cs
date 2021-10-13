/*
 * File Name:           BlackjackHand.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.3
 * Description:         Contains functionality to use multiple decks instead of 1, 
 *                      is limited to 5 via the spinbox component on the game form
 */
using System;
using System.Collections.Generic;
using System.Text;
//using the cards namespace
using Cards;

namespace Blackjack //part of the blackjack namespace
{
	// Deck-like class, containing multiple decks. inherits from the deck class.
    //shoe is a term used for a gambling device which contains multiple decks of cards.
	public class Shoe : Deck
    {
        //constructor for the shoe
		public Shoe(int decks)
			: base()
        {
			// We already contain one deck, add others
			for (int i = 0; i < decks - 1; i++)
            {
				Deck d = new Deck();
				cards.AddRange(d);
			}
		}
	}
}