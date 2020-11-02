using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appnicole
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Valguotoor : ContentPage
	{
		public Valguotoor()
		{
			InitializeComponent();
		}
		Random rnd = new Random();
		private void On_Clicked(object sender, EventArgs e)
		{
			int c = rnd.Next(1, 4);
			if (c == 1)
			{
				pun.BackgroundColor = Color.FromRgb(255, 0, 0);
				gre.BackgroundColor = Color.FromRgb(100, 100, 100);
				kol.BackgroundColor = Color.FromRgb(100, 100, 100);
			}
			else if (c == 2)
			{
				pun.BackgroundColor = Color.FromRgb(100, 100, 100);
				gre.BackgroundColor = Color.FromRgb(255, 215, 0);
				kol.BackgroundColor = Color.FromRgb(100, 100, 100);
			}
			else
			{
				pun.BackgroundColor = Color.FromRgb(100, 100, 100);
				gre.BackgroundColor = Color.FromRgb(100, 100, 100);
				kol.BackgroundColor = Color.FromRgb(0, 255, 0);
			}
		

			//kol.BackgroundColor = Color.Green;
			//gre.BackgroundColor = Color.Yellow;
			//pun.BackgroundColor = Color.Red;

		}

		private void Off_Clicked(object sender, EventArgs e)
		{
			kol.BackgroundColor = Color.FromRgb(100,100,100);
			gre.BackgroundColor = Color.FromRgb(100, 100, 100);
			pun.BackgroundColor = Color.FromRgb(100, 100, 100);

		}
	}
}