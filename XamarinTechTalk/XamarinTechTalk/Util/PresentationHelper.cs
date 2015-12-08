using System;
using System.Threading.Tasks;

namespace XamarinTechTalk
{
    public static class PresentationHelper
    {
        public static async Task PresentHomePage() 
		{
			await NavigationHelper.PushAsync(new HomePage());
        }
    }
}