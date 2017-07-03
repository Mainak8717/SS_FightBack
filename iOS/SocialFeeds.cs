using System;
using System.Threading.Tasks;
using FightBack_SS.iOS;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(SocialFeeds))]
namespace FightBack_SS.iOS
{
	public class SocialFeeds :IAppHandler
	{
		public SocialFeeds()
		{
		}

		public Task<bool> LaunchApp(string uri)
		{
			var canOpen = UIApplication.SharedApplication.CanOpenUrl(new NSUrl(uri));

		    if (!canOpen)
		        return Task.FromResult(false);

		    return Task.FromResult(UIApplication.SharedApplication.OpenUrl(new NSUrl(uri)));
}
	}
}
