using System.Threading.Tasks;
using Android.App;
using Android.OS;
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

			//Task.Run(async () => await ViewModel.DoTest());
			ViewModel.TestCommandAsync.Execute(null);

			System.Diagnostics.Debug.WriteLine("OnResume done");
		}
	}
}
