/*
 * File Name:           PileOfCards.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.0
 * Description:         Abstract class that represents a pile of cards.
 *	                    A pile of cards is a useful abstraction.  Many objects
 *	                    can be piles of cards -- decks, hands, discard piles, 
 *	                    tricks, the flop/turn/river of Texas Hold 'Em, etc.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Cards //part of the cards namespace
{
	
	public abstract class PileOfCards : IEnumerable<Card>
    {
		// Protected list of cards; can be added to by 
		// derived classes.
		protected List<Card> cards = new List<Card>();
        
		// Creates a pile from one or more specified cards (or from none)
		public PileOfCards(params Card[] _cards)
        {
			foreach (var c in _cards)
            {
				cards.Add(c);
			}
		}
        
		// Provide a means of getting a specific card 
		// from the pile.
		// No means of setting this is provided; it may 
		// not be desired.
		public Card this[int index]
        {
			get
            { 
                return cards[index]; 
            }
		}
        
		// Count of cards in the pile.
		public int Count
        {
			get
            { 
                return cards.Count; 
            }
		}
        
		// Support the foreach loop syntax.
		public IEnumerator<Card> GetEnumerator()
        {
			return cards.GetEnumerator();
		}
        
		// Also part of the foreach loop support.
		IEnumerator IEnumerable.GetEnumerator()
        {
			return GetEnumerator();
		}
	}
}
