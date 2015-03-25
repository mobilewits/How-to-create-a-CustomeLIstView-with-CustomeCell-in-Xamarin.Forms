using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
namespace ListViewXamarinForms
{
	public class ListCell : ViewCell
	{
		public ListCell ()
		{
			ListViewEx list = new ListViewEx ();
			var img_image = new Image () {
				HorizontalOptions = LayoutOptions.Start
			};
			img_image.WidthRequest = img_image.HeightRequest = 40;
		
			img_image.SetBinding (Image.SourceProperty, "Img");



			var nameLayout = CreateNameLayout();

			var viewLayout = new StackLayout()
			{
				Orientation = StackOrientation.Horizontal,
				Children = { img_image, nameLayout }
			};

			View = viewLayout;
		
		}
		static StackLayout CreateNameLayout()
		{

			var nameLabel = new Label
			{
				HorizontalOptions= LayoutOptions.FillAndExpand
			};
			nameLabel.SetBinding(Label.TextProperty, "Name");

			var nameLayout = new StackLayout()
			{
				HorizontalOptions = LayoutOptions.StartAndExpand,
				Orientation = StackOrientation.Vertical,
				Children = {nameLabel}
			};

			return nameLayout;
		}
	}
}


