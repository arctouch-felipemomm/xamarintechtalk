using System;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public class PageWithoutNavBar : ContentPage
	{
		public PageWithoutNavBar()
		{
			NavigationPage.SetHasNavigationBar(this, false);

			Button backButton = new Button();
			backButton.Text = "Back";
			backButton.Clicked += BackButtonClicked;

			Content = new StackLayout
			{ 
				Padding = new Thickness(50),
				BackgroundColor = Color.Gray.MultiplyAlpha(0.5),
				Children =
				{
					backButton
				}
			};
		}

		private void BackButtonClicked(object sender, EventArgs e)
		{
			//NavigationHelper.PopAsync();

			((XamarinTechTalk.MainPage)((App)App.Current).MainPage).PopPageAsync();
		}
	}
}


