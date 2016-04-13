using System;
using MvvmCross.Platform.Platform;

namespace TestApp.Droid
{
	internal class DebugTrace : IMvxTrace
	{
		public void Trace(MvxTraceLevel level, string tag, Func<string> message)
		{
			System.Diagnostics.Debug.WriteLine(message());
		}

		public void Trace(MvxTraceLevel level, string tag, string message)
		{
			System.Diagnostics.Debug.WriteLine(message);
		}

		public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
		{
			System.Diagnostics.Debug.WriteLine(message, args);
		}
	}
}