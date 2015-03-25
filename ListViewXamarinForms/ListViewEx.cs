using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewXamarinForms
{
	public class ListViewEx: ContentPage
	{
		public List<data> data1;
		public ListView listview1 = new ListView ();
		public ListViewEx ()
		{
			 data1= new List<data> {
				new data (1,"Apple", "contact.png"),
				new data(2,"Banana", "contact.png"),
				new data (3,"Graps", "contact.png"),
				new data(4,"Orange", "contact.png"),
				new data(5,"Pineapple", "contact.png"),
				new data(6,"Strawberry", "contact.png"),
				new data(6,"Lemon", "contact.png"),
			};

			Label header = new Label
			{
				Text = "ListView Custom Cell",
				Font = Font.BoldSystemFontOfSize(30),
				HorizontalOptions = LayoutOptions.Center
			};

			var Cell = new DataTemplate (typeof(ListCell));


		
			listview1.ItemsSource = data1;
			listview1.ItemTemplate = Cell;
				
			

			//List Selection
			listview1.ItemSelected += (sender, e) => {
				data d=(data) e.SelectedItem;
				DisplayAlert("ListView Item select",d.Name+" Selected","Ok");

			};


			//Delete in ListView




				// The root page of your application

				Content = new StackLayout {
					Padding= new Thickness(0,15,0,0),
					VerticalOptions = LayoutOptions.Center,
					Children = {
						header,listview1
					}
				};
		}
	}
}


