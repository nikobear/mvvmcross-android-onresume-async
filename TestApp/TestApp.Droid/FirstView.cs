using Android.App;
using Android.OS;
using Android.Util;
using MvvmCross.Droid.Views;

namespace TestApp.Droid
{
	[Activity(Label = "FirstView")]
	public class FirstView : MvxActivity<FirstViewModel>
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);
		}
		protected override void OnResume()
		{
			base.OnResume();

			Log.Info("testapp", "hi");
		}
	}
}