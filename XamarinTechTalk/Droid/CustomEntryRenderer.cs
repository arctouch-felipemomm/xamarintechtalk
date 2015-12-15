using Android.Widget;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using XamarinTechTalk;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(XamarinTechTalk.Droid.CustomEntryRenderer))]
namespace XamarinTechTalk.Droid 
{
	public class CustomEntryRenderer : EntryRenderer 
	{
		private CustomEntry entry;
		private EditText editText;  

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e) 
		{
			if (this.editText != null)
			{
				this.editText.EditorAction -= OnEditorAction;
			}

			base.OnElementChanged(e);

			this.entry = (CustomEntry)e.NewElement;
			this.editText = this.Control;
			this.editText.EditorAction += OnEditorAction;
		}

		private void OnEditorAction(object sender, TextView.EditorActionEventArgs e)
		{
			this.entry.OnCompleted(sender, e);
		}
	}
}