using System;

namespace XamarinTechTalk
{
	public class EntryViewModel : ViewModelBase
	{
		private bool focused;
		 
		public bool Focused
		{
		    get
		    {
				return this.focused;
		    }
		    set
		    {
				if (this.focused != value)
		        {
					this.focused = value;
		            RaisePropertyChanged();
		        }
		    }
		}

		public int Item { get; set; }

		public EntryViewModel(int i)
		{
			Item = i;
		}
	}
}

