using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ReadDataFromJson
{
	public partial class DynamicScreen : ContentPage
	{
		public DynamicScreen()
		{
			InitializeComponent();
			readDataFromJson();
		}


		public void readDataFromJson()
		{
			var assembly = typeof(ReadDataViewModel).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("ReadDataFromJson.getbannerdata.json");

			using (var reader = new System.IO.StreamReader(stream))
			{

				var json = reader.ReadToEnd();
				List<RootObjectNewTwo> data = JsonConvert.DeserializeObject<List<RootObjectNewTwo>>(json);

				for (int i = 0; i < data.Count; i++)
				{
					RootObjectNewTwo dataObject = data[i];
					Debug.WriteLine("First Major ID :" + i + "= " + dataObject.Category);
					Debug.WriteLine("First Major Name :" + i + "= " + dataObject.Category_ID);

					StackLayout subStack = new StackLayout();
					subStack.Padding = new Thickness(10);
					subStack.HorizontalOptions = LayoutOptions.FillAndExpand;
					subStack.VerticalOptions = LayoutOptions.Start;
					subStack.Orientation = StackOrientation.Vertical;


					StackLayout subStackChaid = new StackLayout();
					subStackChaid.HorizontalOptions = LayoutOptions.FillAndExpand;
					subStackChaid.VerticalOptions = LayoutOptions.Start;
					subStackChaid.BackgroundColor = Color.Blue;

					Label headerLabel = new Label();
					headerLabel.VerticalOptions = LayoutOptions.Center;
					headerLabel.Text = dataObject.Category;
					headerLabel.TextColor = Color.White;
					headerLabel.FontAttributes = FontAttributes.Bold;
					headerLabel.FontSize = 15;

					subStackChaid.Children.Add(headerLabel);

					StackLayout visibleOrInvisibleStack = new StackLayout();
					visibleOrInvisibleStack.Padding = new Thickness(10);
					visibleOrInvisibleStack.HorizontalOptions = LayoutOptions.FillAndExpand;
					visibleOrInvisibleStack.VerticalOptions = LayoutOptions.Start;
					visibleOrInvisibleStack.Orientation = StackOrientation.Vertical;

					for (int j = 0; j < dataObject.Ratings.Count; j++)
					{
						StackLayout childerenStack = new StackLayout();
						childerenStack.Orientation = StackOrientation.Horizontal;

						Button radioButton = new Button();
						radioButton.HeightRequest = 30;
						radioButton.WidthRequest = 30;
						radioButton.BackgroundColor = Color.Red;

						Label textLabel = new Label();
						textLabel.Text = dataObject.Ratings[j].Rating;
						textLabel.TextColor = Color.Black;
						textLabel.VerticalTextAlignment = TextAlignment.Center;

						childerenStack.Children.Add(radioButton);
						childerenStack.Children.Add(textLabel);

						visibleOrInvisibleStack.Children.Add(childerenStack);
					}

					//for (int j = 0; j < dataObject.EntBehaviors.Count; j++)
					//{
					//	StackLayout childerenStack = new StackLayout();
					//	childerenStack.Orientation = StackOrientation.Horizontal;

					//	Button radioButton = new Button();
					//	radioButton.HeightRequest = 30;
					//	radioButton.WidthRequest = 30;
					//	radioButton.BackgroundColor = Color.Red;

					//	Label textLabel = new Label();
					//	textLabel.Text = dataObject.EntBehaviors[j].;
					//	textLabel.TextColor = Color.Black;
					//	textLabel.VerticalTextAlignment = TextAlignment.Center;

					//	childerenStack.Children.Add(radioButton);
					//	childerenStack.Children.Add(textLabel);

					//	visibleOrInvisibleStack.Children.Add(childerenStack);
					//}



					subStack.Children.Add(subStackChaid);
					subStack.Children.Add(visibleOrInvisibleStack);

					mainStackLayout.Children.Add(subStack);

				}

			}
		}
	}
}
