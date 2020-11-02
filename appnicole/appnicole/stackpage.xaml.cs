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
	public partial class stackpage : ContentPage
	{
		public stackpage()
		{
			InitializeComponent();
		}
		int clik = 0;
		private void btn_Clicked(object sender, EventArgs e)
		{
			//btn.Text = "Оу май";
			clik = clik + 1;
			btn.Text = clik.ToString();
			if (clik % 5 == 0)
			{
				lbl.IsVisible = false;
				lbl.Text = "";
			}
			else
			{
				lbl.Text = "Nupp";
			}
		

		}

		private void btn2_Clicked(object sender, EventArgs e)
		{
				clik = 0;
				btn.Text = clik.ToString();
		}
	}
}