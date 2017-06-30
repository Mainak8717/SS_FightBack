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
				OnRegisterButtonClicked();
			};
			Register.GestureRecognizers.Add(tapGestureRecognizer);
		}
		void OnRegisterButtonClicked()
		{
			//App.Current.MainPage = new SportsmanSpiritFightBack_HomeScreen();
		}
	}
}