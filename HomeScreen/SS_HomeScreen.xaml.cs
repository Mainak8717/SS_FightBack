using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace FightBack_SS
{
	public partial class SS_HomeScreen : ContentPage
	{
		public SS_HomeScreen()
		{
			InitializeComponent();
		}
		async void OnSocialMediaBtnClicked(Object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("Social Feeds", "Cancel", null, "Twitter", "Facebook");
						switch (action.ToString())
						{
							case "Facebook":
								{
									switch (Device.RuntimePlatform) {
										case "iOS":
							case "Android":
								{
									try
									{
										Device.OpenUri(new Uri("fb://page/183489181762575"));
									}
									catch
									{
										Device.OpenUri(new Uri("https://www.facebook.com/sportsmanspirit/"));
									}
									break;
								}
									}
									break;
								}
						}
		}
	}
}
