﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Home.UI.Units
{
    public class Thumbnail : Control
    {
        #region DefaultStyleKey

        static Thumbnail()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Thumbnail), new FrameworkPropertyMetadata(typeof(Thumbnail)));
        }
		#endregion
	}
}
