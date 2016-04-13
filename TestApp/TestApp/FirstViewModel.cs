using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace TestApp
{
	public class FirstViewModel : MvxViewModel
	{
		public ICommand TestCommandAsync => new MvxAsyncCommand(DoTestCommandAsync);

		private async Task DoTestCommandAsync()
		{
			await DoTest();
		}

		public async Task DoTest()
		{
			await Task.Delay(1000);

			Debug.WriteLine("DoTest Delay done");

			throw new Exception();
		}
	}
}
