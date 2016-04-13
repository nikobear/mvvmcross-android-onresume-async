using Android.App;
using MvvmCross.Droid.Views;

namespace TestApp.Droid
{
	[Activity(Label = "SplashScreen",
				MainLauncher = true,
				NoHistory = true)]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen() : base(Resource.Layout.SplashScreen)
		{
		}
	}
}