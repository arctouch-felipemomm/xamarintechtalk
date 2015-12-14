using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTechTalk
{
	[ContentProperty("ElementName")]
	public class ElementSourceExtension : IMarkupExtension
	{
		public ElementSourceExtension()
		{
		}

		public string ElementName { get; set; }

		#region IMarkupExtension implementation

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			IRootObjectProvider rootProvider = serviceProvider.GetService(typeof(IRootObjectProvider)) as IRootObjectProvider;
			if (rootProvider == null)
			{
				return null;
			}

			Element root = rootProvider.RootObject as Element;
			if (root == null)
			{
				return null;
			}

			return root.FindByName<Element>(ElementName);
		}

		#endregion
	}
}

