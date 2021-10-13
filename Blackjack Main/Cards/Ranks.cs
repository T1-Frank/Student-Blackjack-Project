/*
 * File Name:           Ranks.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.0
 * Description:         Enumerator for the different card ranks
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards //part of the cards namespace
{
	public enum Ranks
    {
		Joker   = 0,		// Not used for Blackjack, but might be useful for other games
		Ace     = 1,
		Two     = 2,
		Three   = 3,
		Four    = 4,
		Five    = 5,
		Six     = 6,
		Seven   = 7,
		Eight   = 8,
		Nine    = 9,
		Ten     = 10,
		Jack    = 11,
		Queen   = 12,
		King    = 13
	}
}
