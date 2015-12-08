using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public partial class MathPage : ContentPage
	{
		public MathPage()
		{
			InitializeComponent();

			BindingContext = new MathPageViewModel();
		}

//		private void SumClicked(object sender, EventArgs e)
//		{
//			long result = Math.Sum(Int64.Parse(txtNumber1.Text), Int64.Parse(txtNumber2.Text));
//
//			lblResult.Text = String.Format("Result: {0}", result);
//		}
	}
}

