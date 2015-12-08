using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinTechTalk
{
	public class MainPage : MasterDetailPage
	{
		
		private ContentPage sideMenuPage;
		private NavigationPage navigationPage;

		public MainPage()
		{
			Title = "HOME";

			this.sideMenuPage = new SideMenuPage()
				{
					Title = "HOME",
					Icon = "menu",
					BackgroundColor = Color.Gray
				};
			this.navigationPage = new NavigationPage()
				{
					BarTextColor = Color.Black,
					BarBackgroundColor = Color.Gray
				};

			Master = this.sideMenuPage;
			Detail = this.navigationPage;
			MasterBehavior = MasterBehavior.Popover;
		}

		public Task PushPageAsync(Page page)
		{
			IsPresented = false;
			return this.navigationPage.PushAsync(page);
		}

		public Task<Page> PopPageAsync()
		{
			IsPresented = false;
			return this.navigationPage.PopAsync();
		}

		public Task PopToRootAsync(bool animate = true)
		{
			IsPresented = false;
			return this.navigationPage.PopToRootAsync(animate);
		}

		public async Task OnStart()
		{
			await PushPageAsync(new HomePage());
		}
	}
}