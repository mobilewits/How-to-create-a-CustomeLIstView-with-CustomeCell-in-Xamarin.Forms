using System;

namespace ListViewXamarinForms
{
	public class data
	{
		public int Number {get; set;}
			public string Name { get; set;}
			public string Img { get; set;}
			public data(int number,string name,string img){
				this.Number = number;
				this.Name=name;
				this.Img=img;
			}
	}
}

