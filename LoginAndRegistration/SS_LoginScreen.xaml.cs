using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace FightBack_SS
{
	public partial class SS_LoginScreen : ContentPage
	{
		public SS_LoginScreen()
		{
			InitializeComponent();

			var tapGestureRecognizerLogin = new TapGestureRecognizer();
			tapGestureRecognizerLogin.NumberOfTapsRequired = 1;
				tapGestureRecognizerLogin.Tapped += (s, e) => {
				OnLoginButtonClicked();
			};
			//signInLbl.GestureRecognizers.Add(tapGestureRecognizerLogin);	

			var tapGestureRecognizerGuest = new TapGestureRecognizer();
			tapGestureRecognizerGuest.NumberOfTapsRequired = 1;
			tapGestureRecognizerGuest.Tapped += (s, e) => {
				OnGuestButtonClicked();
			};
			//guestLbl.GestureRecognizers.Add(tapGestureRecognizerGuest);	

			var tapGestureRecognizerRegistration = new TapGestureRecognizer();
			tapGestureRecognizerRegistration.NumberOfTapsRequired = 1;
			tapGestureRecognizerRegistration.Tapped += (s, e) => {
				OnRegistrationButtonClicked();
			};
			//registerLbl.GestureRecognizers.Add(tapGestureRecognizerRegistration);
		}

		async void OnGuestButtonClicked()
		{
			Application.Current.MainPage = new SS_HomeScreen();
		}
		void OnLoginButtonClicked()
		{
			Application.Current.MainPage = new SS_SideMenuMasterDetail();
		}
		void OnRegistrationButtonClicked()
		{
			Application.Current.MainPage = new SS_RegistrationScreen();
		}
	}
}
