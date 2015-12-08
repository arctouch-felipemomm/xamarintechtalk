using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinTechTalk
{
    public static class NavigationHelper
    {
        public static NavigationPage NavigationPage { get; set; }

        public static async Task<Page> Init() 
		{
            NavigationHelper.NavigationPage = new NavigationPage();
			await PresentationHelper.PresentHomePage();

            return NavigationHelper.NavigationPage;
        }

        public static async System.Threading.Tasks.Task<Page> PopAsync () 
		{
            return await NavigationHelper.NavigationPage.Navigation.PopAsync();
        }

        public static async System.Threading.Tasks.Task PopToRootAsync () 
		{
            await NavigationHelper.NavigationPage.Navigation.PopToRootAsync();
        }

        public static async System.Threading.Tasks.Task PushAsync (Page page) 
		{
            await NavigationHelper.NavigationPage.Navigation.PushAsync(page);
        }

        /*public static async System.Threading.Tasks.Task PushModalAsync (Page page) 
		{
            await NavigationHelper.NavigationPage.Navigation.PushModalAsync(page);
        }

		public static async System.Threading.Tasks.Task<Page> PopModalAsync () 
		{
			return await NavigationHelper.NavigationPage.Navigation.PopModalAsync();
		}*/
    }
}

