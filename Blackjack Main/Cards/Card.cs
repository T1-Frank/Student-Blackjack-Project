/*
 * File Name:           Card.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.0
 * Description:         Class that represents a single card.
 *	                    It represents everything about a card that we think is important.
 *	                    Also, note that it supports features we don't actually need for Blackjack, 
 *	                    such as the Joker.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards //part of the cards namespace
{
	public class Card
    {
		// Flipped event, fired when the card's face up/down setting is actually changed.
		public event EventHandler Flipped;
        
		// Defaults (this makes them easy to change everywhere at once)
		public const Backs DefaultBack = Backs.Bellagio;
        
		// Face-up property, with code to fire Flipped event.
        //code is in its public set method
		private bool faceUp = false;
	

		// Simple properties
		public Suits Suit
        { 
            get; 
            private set; 
        }

		public Ranks Rank
        { 
            get; 
            private set; 
        }

		public Backs Back
        { 
            get; 
            private set; 
        }

	    public bool FaceUp
        {
			get
            { 
                return faceUp; 
            }
			set
            {
				bool oldValue = faceUp;
				faceUp = value;
                if (oldValue != faceUp && Flipped != null)
                {
                    Flipped(this, EventArgs.Empty);
                }
			}
		}
        
		// Card's name (e.g. "Jack of Spades")
		public string Name
        {
			get
            {
				if (Rank == Ranks.Joker) return Rank.ToString();
				return Rank + " of " + Suit; 
			}
		}
        
		// Card's display value (card name if face-up, card back if face-down).
		public string CardDisplay
        {
			get
            {
                if (FaceUp)
                {
                    return Name;
                }

				return Back.ToString();
			}
		}
        //constructor for card class (is overloaded)
		public Card(Suits suit, Ranks rank) 
            :this(suit, rank, DefaultBack)
        {	
        }
        //constructor for card class (is overloaded)
		public Card(Suits suit, Ranks rank, Backs back)
        {
			Suit = (rank == Ranks.Joker ? Suits.None : suit);
			Rank = rank;
			Back = back;
		}

		public override string ToString()
        {
			return CardDisplay;
		}
	}
}
