using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadDataFromJson
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage(MyJsseResponse.RootObjectJSSE selecteJSSEObject)
		{
			InitializeComponent();
			this.BindingContext = new SecondPageViewModel(selecteJSSEObject);
		}
	}
}
