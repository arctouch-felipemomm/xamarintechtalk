using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();

			//NavigationPage.SetHasNavigationBar(this, false);
		}

		private void GoToClicked(object sender, EventArgs e)
		{
			//NavigationHelper.PushAsync(new PageWithoutNavBar());

			((XamarinTechTalk.MainPage)((App)App.Current).MainPage).PushPageAsync(new PageWithoutNavBar());
		}
	}
}

