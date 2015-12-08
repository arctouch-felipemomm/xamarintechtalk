using System;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public class App : Application
	{
		XamarinTechTalk.MainPage mainPage;

		public App()
		{
			//MainPage = NavigationHelper.Init().Result;

			mainPage = new XamarinTechTalk.MainPage();
			MainPage = new ContentPage();
		}

		protected override async void OnStart()
		{
			await this.mainPage.OnStart();
			MainPage = this.mainPage;
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

