/*
 * File Name:           Program.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.0
 * Description:         Main entry point for the application
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack
{
	static class Program
    {
		[STAThread]
		static void Main()
        {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormGame());
		}
	}
}