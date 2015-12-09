using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamarinTechTalk
{
	public class MathPageViewModel : ViewModelBase
	{
		private long number1;

		public long Number1 
		{
			get
			{
				return this.number1;
			}

			set
			{
				if (this.number1 != value)
				{
					this.number1 = value;

					RaisePropertyChanged();
				}
			}
		}

		private long number2;

		public long Number2 
		{
			get
			{
				return this.number2;
			}

			set
			{
				if (this.number2 != value)
				{
					this.number2 = value;

					RaisePropertyChanged();
				}
			}
		}

		private bool isLoading;

		public bool IsLoading 
		{
			get
			{
				return this.isLoading;
			}

			set
			{
				if (this.isLoading != value)
				{
					this.isLoading = value;

					RaisePropertyChanged();
				}
			}
		}

		private string result;

		public string Result 
		{
			get
			{
				return this.result;
			}

			set
			{
				if (this.result != value)
				{
					this.result = value;

					RaisePropertyChanged();
				}
			}
		}

		public ICommand SumCommand { get; private set; }

		public MathPageViewModel()
		{
			SumCommand = new Command(Sum);

			Result = "Result: ";
		}

		private async void Sum()
		{
			IsLoading = true;

			long mathResult = await Math.SumAsync(Number1, Number2);

			Result = String.Format("Result: {0}", mathResult);

			IsLoading = false;
		}
	}
}

