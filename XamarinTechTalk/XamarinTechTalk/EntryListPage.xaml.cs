using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public partial class EntryListPage : ContentPage
	{
		public EntryListPage()
		{
			InitializeComponent();

			BindingContext = new EntryListPageViewModel();
		}
	}
}

