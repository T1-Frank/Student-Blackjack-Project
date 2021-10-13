/*
 * File Name:           CardPanel.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.1
 * Description:         Control that draws cards given a PileOfCards.  
 *	                    (The control draws a few random cards in Design mode.)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Cards //part of the cards namespace
{
	
	public partial class CardPanel : UserControl
    {
		// Static randomizer
		static private Random random = new Random();

		public CardPanel()
        {
			InitializeComponent();

			// This removes default erasure behavior and allows all drawing to 
			//	be controlled by our code.  It also adds double-buffering.  
			//	Double-buffering means that drawing takes place on a memory (non-visible)
			//	"image" and then is thrown forward as quickly as possible after 
			//	all the rendering is complete.
			this.SetStyle(ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.ResizeRedraw, true);
		}
        //boolean for whether the current hand is highlighted
		private bool highlight = false;
		public bool Highlight
        {
			get
            { 
                return highlight; 
            }
			set
            {
				highlight = value;
				this.Invalidate();
			}
		}
        //text for the card panel, used to display the value of the hand and messages
		private string text = string.Empty;
		public new string Text
        {
			get
            { 
                return text; 
            }
			set
            {
				text = value;
				this.Invalidate();
			}
		}
        
		// Redraws cards after a change.
		public virtual new void Refresh()
        {
			this.Invalidate();
		}

		[Browsable(false)]
		public PileOfCards Cards
        { 
            get; set; 
        }
        // This is not a property so that the Designer doesn't try to save it.
        private List<Card> designModeCards = null;		

        //drawing cards from the images resource
		private void CardPanel_Paint(object sender, PaintEventArgs e)
        {
			IEnumerable<Card> cardsToDraw = Cards as IEnumerable<Card>;
			string textToDraw = text;

			if (this.DesignMode)
            {
				// Advertise by drawing a few cards
                //is implemented in blackjackHandPanel design view
				if (designModeCards == null)
                {
					designModeCards = new List<Card>();
					for (int i = 0; i < random.Next(1, 4); i++)
                    {
						Card c = new Card((Suits)(random.Next(1, Enum.GetValues(typeof(Suits)).Length)),
							(Ranks)(random.Next(Enum.GetValues(typeof(Ranks)).Length)));
						c.FaceUp = (random.NextDouble() > 0.3);
						designModeCards.Add(c);
					}
				}
				cardsToDraw = designModeCards;
				textToDraw = "Sample";
			}

			// Draw cards
			if (cardsToDraw != null)
            {
				int x = 10, y = 10;
				foreach (Card c in cardsToDraw)
                {
					e.Graphics.DrawImage(Resources.GetImage(c.CardDisplay), x, y);
					x += 15;
					y += 10;
				}
			}

			// Draw text
			if (!string.IsNullOrEmpty(textToDraw))
            {
				StringFormat sf = new StringFormat();
				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Center;
				e.Graphics.DrawString(textToDraw, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
			}

			// Draw a yellow highlight inside any border, used to show active hand
			if (Highlight)
            {
				Pen yellowPen = new Pen(Color.Yellow, 3.0f);
				e.Graphics.DrawRectangle(yellowPen, this.ClientRectangle);
			}
		}
	}
}
