using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace XamarinTechTalk
{
	public class EntryListPageViewModel : ViewModelBase
	{
		private ObservableCollection<EntryViewModel> entries;
		 
		public ObservableCollection<EntryViewModel> Entries
		{
		    get
		    {
		        return this.entries;
		    }
		    set
		    {
		        if (this.entries != value)
		        {
		            this.entries = value;
		            RaisePropertyChanged();
		        }
		    }
		}

		public ICommand FocusNextItemCommand { get; private set; }

		public EntryListPageViewModel()
		{
			FocusNextItemCommand = new Command<EntryViewModel>(FocusNextItem);

			Entries = new ObservableCollection<EntryViewModel>();

			for (int i = 0; i < 10; i++)
			{
				Entries.Add(new EntryViewModel(i));
			}
		}

		private void FocusNextItem(EntryViewModel currentEntry)
		{
			bool focusNextItem = false;
			foreach (var entry in Entries)
			{
				if (focusNextItem)
				{
					entry.Focused = true;
					return;
				}

				if (entry.Equals(currentEntry))
				{
					focusNextItem = true;
				}
			}	
		}
	}
}

