using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using FightBack_SS.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(SocialFeeds))]
namespace FightBack_SS.Droid
{
	public class SocialFeeds:Activity, IAppHandler
	{
		public SocialFeeds()
		{
		}
		public Task<bool> LaunchApp(string uri)
		{
			try
			{
				Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage(uri);

				if (intent != null)
				{
					intent.AddFlags(ActivityFlags.NewTask);
					Forms.Context.StartActivity(intent);
				}
				else
				{
					intent = new Intent(Intent.ActionView);
					intent.AddFlags(ActivityFlags.NewTask);
					intent.SetData(Android.Net.Uri.Parse(uri)); // This launches the PlayStore and search for the app if it's not installed on your device
					Forms.Context.StartActivity(intent);
				}
				return Task.FromResult(true);
			}
			catch (Exception e)
			{
			}
            return Task.FromResult(false);
        }
	}
}
