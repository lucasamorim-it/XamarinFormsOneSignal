using Com.OneSignal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFOneSignal
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new XFOneSignal.MainPage();
            OneSignal.Current.StartInit("d777c476-4bc8-4a3b-8ba7-2c1b484a32cd")
                 .EndInit();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
