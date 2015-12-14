using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamarinTechTalk
{
	public class CustomEntry : Entry
	{
		public CustomEntry()
		{
			Completed += OnCompleted;
		}

		public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(CustomEntry), null, BindingMode.OneWay, null, null, null, null, null);

		public ICommand Command
		{
			get
			{
				return (ICommand)base.GetValue(CommandProperty);
			}

			set
			{
				base.SetValue(CommandProperty, value);
			}
		}

		public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(CustomEntry), null, BindingMode.OneWay, null, null, null, null, null);

		public object CommandParameter
		{
			get
			{
				return base.GetValue(CommandParameterProperty);
			}

			set
			{
				base.SetValue(CommandParameterProperty, value);
			}
		}

		public static readonly BindableProperty HasFocusProperty = BindableProperty.Create("HasFocus", typeof(bool), typeof(CustomEntry), false, BindingMode.TwoWay, null, FocusChanged);

		private static void FocusChanged(BindableObject bindable, object oldValue, object newValue)
		{
			CustomEntry entryEx = (CustomEntry)bindable;
			entryEx.Focus();
			entryEx.HasFocus = false; // Returns to false to get focused again if needed
		}

		public bool HasFocus
		{
			get
			{
				return (bool)GetValue(HasFocusProperty);
			}
			set
			{
				SetValue(HasFocusProperty, value);
			}
		}

		public void OnCompleted(object sender, EventArgs e)
		{
			ExecuteCommand();
		}     

		private void ExecuteCommand()
		{
			ICommand command = Command;
			if (command != null)
			{
				object parameter = CommandParameter;
				command.Execute(parameter);
			}
		}
	}
}


