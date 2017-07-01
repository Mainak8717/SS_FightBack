using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FightBack_SS
{
	public partial class SS_RegistrationScreen : ContentPage
	{
		public SS_RegistrationScreen()
		{
			InitializeComponent();
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.NumberOfTapsRequired = 1;
			tapGestureRecognizer.Tapped += (s, e) =>
			{
				OnButtonClicked(s,e);
			};
			Submit.GestureRecognizers.Add(tapGestureRecognizer);
			Cancel.GestureRecognizers.Add(tapGestureRecognizer);
		}
		void OnButtonClicked(Object sender, EventArgs e)
		{
			Label labelClicked = (Label)sender as Label;
			switch (labelClicked.Text)
       		 {
	            case "SUBMIT":
					Application.Current.MainPage = new SS_SideMenuMasterDetail();
	                break;
	            case "CANCEL":
					Application.Current.MainPage = new SS_LoginScreen();
	                break;
       		 }
		}
	}
}