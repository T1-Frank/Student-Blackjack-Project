/*
 * File Name:           Suits.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.0
 * Description:         Enumerator for suits
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Cards
{
	// Enumeration of card suits
	public enum Suits
    {
		None     = 0,		// Used for jokers
		Clubs    = 1,
		Diamonds = 2,
		Hearts   = 3,
		Spades   = 4
	}
}
