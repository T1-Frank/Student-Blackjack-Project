/*
 * File Name:           Deck.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      2.1
 * Description:         code to create a standard deck of 52 playing cards as well 
 *                      as 2 shuffling methods (blackjack program uses perfect shuffle)
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Cards //part of the cards namespace
{
	public class Deck : PileOfCards
    {
		static private Random random = new Random();
        
		// Create a standard deck of 52 cards.
        public Deck()
            : this(false)
        {
        }
        
		// Creates a deck of 52 cards with a joker.
		public Deck(bool includeJoker)
        {
			foreach (Suits suit in new [] {Suits.Clubs, Suits.Diamonds, Suits.Hearts, Suits.Spades } )
            {
				foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
                {
					if (rank != Ranks.Joker) cards.Add(new Card(suit, rank));
				}
			}
            //adds two jokers
            if (includeJoker)
            {
                cards.Add(new Card(Suits.None, Ranks.Joker));
                cards.Add(new Card(Suits.None, Ranks.Joker));
            }
		}
        
		//constructor for deck
		public Deck(params Card[] cards)
			: base(cards)
        {
			
		}
        
		// Shuffle the deck by swapping random cards
		public void Shuffle()
        {
			// for each Card, pick another random Card and swap them
			for (int i = 0; i < this.Count; i++)
            {
				// select a random card position:
				int second = random.Next(this.Count);

				// swap current Card with randomly selected Card
				Card temp = cards[i];
				cards[i] = cards[second];
				cards[second] = temp;
			}
		}
        
        //Shuffle by copying a card from a random index to a new arraylist and removing it from the original list
        public void PerfectShuffle()
        {
            List<Card> copy = new List<Card>(cards);
            int randomIndex = 0;
            for (int i = 0; i < Count; ++i)
            {
                randomIndex = RandBetween(i, Count - 1);
                copy[i] = cards[randomIndex];
                cards.RemoveAt(randomIndex);
            }

            cards = copy;
        }

        //chooses a random integer number between 2 values
        private int RandBetween(int lower, int higher)
        {
            return lower + random.Next(higher - lower + 1);
        }
        //deals cards (calls its overloaded counterpart with and ensures the card is dealt face down)
		public Card Deal()
        {
			return Deal(false);
		}
        //deals cards with parameter for faceup or down
		public Card Deal(bool faceUp)
        {
			Card c = cards[0];
			cards.RemoveAt(0);
			c.FaceUp = faceUp;
			return c;
		}
	}
}
