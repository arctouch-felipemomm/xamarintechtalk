using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public partial class SideMenuPage : ContentPage
	{
		public SideMenuPage()
		{
			InitializeComponent();
		}

		private void HomeClicked(object sender, EventArgs e)
		{
			((XamarinTechTalk.MainPage)((App)Application.Current).MainPage).PopToRootAsync();
		}

		private void MathPageClicked(object sender, EventArgs e)
		{
			((XamarinTechTalk.MainPage)((App)Application.Current).MainPage).PushPageAsync(new MathPage());
		}

		private void PageWithoutNavBarClicked(object sender, EventArgs e)
		{
			((XamarinTechTalk.MainPage)((App)Application.Current).MainPage).PushPageAsync(new PageWithoutNavBar());
		}
	}
}

