/*
 * File Name:           Resources.cs
 * Author:              Francois Cloete W7MSRF657
 * Date Created:        22 May 2017
 * Operating System:    Windows 7 64-bit
 * Version Number:      1.1
 * Description:         code used to load all images for cards.
 *                      all images are stored in the same .net managed resource folder.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Drawing;

namespace Cards //part of the cards namespace
{
	static public class Resources
    {
		private static ResourceManager images;

		static Resources()
        {
			images = new ResourceManager("Cards.Images", Assembly.GetExecutingAssembly());
		}

		public static ResourceManager Images
        {
			get { return images; }
		}

		public static Image GetImage(int imageId)
        {
			return (Image)images.GetObject(imageId.ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
		}

		public static Image GetImage(string imageId)
        {
			return (Image)images.GetObject(imageId, CultureInfo.InvariantCulture);
		}
	}
}
